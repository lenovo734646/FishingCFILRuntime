package com.qq1798.buyu;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.os.Message;
import android.util.Log;
import android.widget.Toast;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Bitmap.CompressFormat;

import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.BufferedReader;

import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;

import android.content.pm.PackageManager;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;


import com.tencent.mm.opensdk.constants.Build;
import com.tencent.mm.opensdk.openapi.IWXAPI;
import com.tencent.mm.opensdk.openapi.WXAPIFactory;
import com.tencent.mm.opensdk.modelmsg.SendAuth;
import com.tencent.mm.opensdk.modelpay.PayReq;

import com.tencent.mm.opensdk.modelmsg.WXImageObject;
import com.tencent.mm.opensdk.modelmsg.WXMediaMessage;
import com.tencent.mm.opensdk.modelmsg.WXMusicObject;
import com.tencent.mm.opensdk.modelmsg.WXTextObject;
import com.tencent.mm.opensdk.modelmsg.WXVideoObject;
import com.tencent.mm.opensdk.modelmsg.WXWebpageObject;
import com.tencent.mm.opensdk.modelmsg.SendMessageToWX;

import com.alipay.sdk.app.AuthTask;
import com.alipay.sdk.app.PayTask;

import com.qq1798.buyu.Constants;

import com.unity3d.player.UnityPlayerActivity;
import com.unity3d.player.UnityPlayer;

import java.util.Map;


public class MainActivity extends UnityPlayerActivity{
    //通过code获取access_token地址
	public final static String WXLOGIN_URL = "https://api.weixin.qq.com/sns/oauth2/access_token";
	//验证access_token是否有效地址
	public final static String WXACCESS_TOKEN_URL = "https://api.weixin.qq.com/sns/auth?access_token=";
    //通过access_token调用接口,获取用户信息
	public final static String WXGETUSER_URL = "https://api.weixin.qq.com/sns/userinfo?access_token=";
	//refresh_token拥有较长的有效期（30天），当refresh_token失效的后，需要用户重新授权
	public final static String WXREFRESH_URL = "https://api.weixin.qq.com/sns/oauth2/refresh_token?appid=";


	//private static String appid = "wxd930ea5d5a258f4f"
	private static IWXAPI iwxapi;
 
    public static IWXAPI getWXAPI(Context context, String appid){
        if (iwxapi == null){
            //通过WXAPIFactory创建IWAPI实例
            iwxapi = WXAPIFactory.createWXAPI(context, appid, false);
            //将应用的appid注册到微信
            iwxapi.registerApp(appid);
        }
        return iwxapi;
    }

    
    // public static void OpenWechat()
    // {
    //     // 如果手机上安装了微信，就打开微信的主界面
    //     try 
    //     {
    //         PackageManager packageManager = getPackageManager();   
    //         Intent intent=new Intent();   
    //         intent = packageManager.getLaunchIntentForPackage("com.tencent.mm"); //填写微信包名 
    //         startActivity(intent);
    //     } 
    //     catch (Exception e)//如果没有安装就打开一个浏览器去下载
    //     {
    //         e.printStackTrace();  
    //         Intent viewIntent = new  
    //         Intent("android.intent.action.VIEW",Uri.parse("http://weixin.qq.com/"));  
    //         startActivity(viewIntent);          
    //     }

    // }

	public static void WechatLogin(Context context, String appid)
	{
		if(!judgeCanGo(context, appid))
		{
			return;
		}
		Constants.context = context;
        Constants.APP_ID = appid;

		String text = "WechatLogin";
		Toast.makeText(Constants.context, text, Toast.LENGTH_LONG).show();
        
        if (Constants.APP_ID != null) {
			final SendAuth.Req req = new SendAuth.Req();
			req.scope = "snsapi_userinfo";
			req.state = String.valueOf(System.currentTimeMillis());
			iwxapi.sendReq(req);
        }
	}

    public static void WechatPay(Context context, String appid, String partnerid, String prepayid, String packagevalue, String noncestr, String timestamp, String sign)
	{
		if(!judgeCanGo(context, appid))
		{
			return;
		}
		Constants.context = context;
		Constants.APP_ID = appid;

		PayReq payReq = new PayReq();
        payReq.appId = appid;
        payReq.partnerId = partnerid;
        payReq.prepayId = prepayid;
        payReq.packageValue = packagevalue;
        payReq.nonceStr = noncestr;
        payReq.timeStamp = timestamp;
        payReq.sign = sign;

        iwxapi.sendReq(payReq);
	}

    /**
     * 分享文本至朋友圈
     * @param text  文本内容
     * @param judge 类型选择 好友-WECHAT_FRIEND 朋友圈-WECHAT_MOMENT
     */
    public static void WxTextShare(Context context, String appid,String text,int judge){
        if (!judgeCanGo(context, appid))
		{
            return;
        }
        //初始化WXTextObject对象，填写对应分享的文本内容
        WXTextObject textObject = new WXTextObject();
        textObject.text = text;
        //初始化WXMediaMessage消息对象，
        WXMediaMessage message = new WXMediaMessage();
        message.mediaObject = textObject;
        message.description = text;
        //构建一个Req请求对象
        SendMessageToWX.Req req = new SendMessageToWX.Req();
        req.transaction = String.valueOf(System.currentTimeMillis());   //transaction用于标识请求
        req.message = message;
        req.scene = judge;      //分享类型 好友==0 朋友圈==1
        //发送请求
        iwxapi.sendReq(req);
    }

	/**
     *  分享图片
     * @param bitmap 图片bitmap,建议别超过32k
     * @param judge 类型选择 好友-WECHAT_FRIEND 朋友圈-WECHAT_MOMENT
     */
    public static void WxBitmapShare(Context context, String appid, Bitmap bitmap,int judge){
        if (!judgeCanGo(context, appid)){
            return;
        }
        WXImageObject wxImageObject = new WXImageObject(bitmap);
        WXMediaMessage message = new WXMediaMessage();
        message.mediaObject = wxImageObject;
 
        Bitmap thunmpBmp = Bitmap.createScaledBitmap(bitmap,50,50,true);
        bitmap.recycle();
        message.thumbData = ImageUtil.bmpToByteArray(thunmpBmp,true);
 
        SendMessageToWX.Req req = new SendMessageToWX.Req();
        req.transaction = String.valueOf(System.currentTimeMillis());
        req.message = message;
        req.scene = judge;
 
        iwxapi.sendReq(req);
 
    }
 
    /**
     * 网页分享
     * @param url  地址
     * @param title 标题
     * @param description  描述
     * @param judge  类型选择 好友-WECHAT_FRIEND 朋友圈-WECHAT_MOMENT
     */
    public static void WxUrlShare(Context context, String appid, String url,String title,String description,String imgUrl,int judge){
        if (!judgeCanGo(context, appid)){
            return;
        }
        Bitmap bitmap = getBitMBitmap(imgUrl);
        WXWebpageObject wxWebpageObject = new WXWebpageObject();
        wxWebpageObject.webpageUrl = url;
 
        WXMediaMessage wxMediaMessage = new WXMediaMessage(wxWebpageObject);
        wxMediaMessage.title = title;
        wxMediaMessage.description = description;
        Bitmap thunmpBmp = Bitmap.createScaledBitmap(bitmap,50,50,true);
        bitmap.recycle();
        wxMediaMessage.thumbData = ImageUtil.bmpToByteArray(thunmpBmp,true);
 
        SendMessageToWX.Req req = new SendMessageToWX.Req();
        req.transaction = String.valueOf(System.currentTimeMillis());
        req.message = wxMediaMessage;
        req.scene = judge;
 
        iwxapi.sendReq(req);
    }
 
    /**
     * 图片网址url转bitmap
     */
    public static Bitmap getBitMBitmap(String urlpath) {
        Bitmap map = null;
        try {
            URL url = new URL(urlpath);
            URLConnection conn = url.openConnection();
            conn.connect();
            InputStream in;
            in = conn.getInputStream();
            map = BitmapFactory.decodeStream(in);
            // TODO Auto-generated catch block
        } catch (IOException e) {
            e.printStackTrace();
        }
        return map;
    }


	private static boolean judgeCanGo(Context context, String appid){
        IWXAPI api = getWXAPI(context, appid);
		if(api == null)
		{
			UnityPlayer.UnitySendMessage("LuaRuntime","OnWechatError","createWXAPI failed");
			return false;
		}
        if (!iwxapi.isWXAppInstalled()) {
            //Toast.makeText(context, "请先安装微信应用", Toast.LENGTH_SHORT).show();
			UnityPlayer.UnitySendMessage("LuaRuntime","OnWechatNotInstall","");
            return false;
        } else if (iwxapi.getWXAppSupportAPI() < Build.TIMELINE_SUPPORTED_SDK_INT) {
            //Toast.makeText(context, "请先更新微信应用", Toast.LENGTH_SHORT).show();
			UnityPlayer.UnitySendMessage("LuaRuntime","OnWechatAPINotSupport","");
            return false;
        }
        return true;
    }

	// 阿里支付
	public static void AliPay(final Context context, final String envir)
	{
		final Runnable payRunnable = new Runnable() {

			@Override
			public void run() {
				PayTask alipay = new PayTask((Activity)context);
				Map<String, String> result = alipay.payV2(envir, true);
				Log.i("msp", result.toString());
			}
		};

		Thread payThread = new Thread(payRunnable);
		payThread.start();
	}

    /**
	 * 通过code获取access_token
	 */
	public void getAccessToken(String appid, String appsecret, String code) throws Exception{
        String url = WXLOGIN_URL+"?appid=" + appid + "&secret="
        + appsecret + "&code=" + code + "&grant_type=authorization_code";
        String ret =  GetJsonDataFromUrl(url);
        UnityPlayer.UnitySendMessage("LuaRuntime","OnGetAccessToken",ret);
	}

    /**
     * 验证授权凭证（access_token）是否有效
     * @param accessToken
     * @param openID
     * @return
     */
    public static void isAccessTokenIsInvalid(String accessToken,String openID) {
        String url = WXACCESS_TOKEN_URL + accessToken + "&openid=" + openID+"&lang=zh_CN";
        String ret =  GetJsonDataFromUrl(url);
        UnityPlayer.UnitySendMessage("LuaRuntime","IsAccessTokenIsInvalid",ret);
    }

    /**
     * 刷新或续期 access_token
     */
    public static void refreshAccessToken(String appid, String refreshToken) {
        String url = WXREFRESH_URL + appid + "&grant_type=refresh_token&refresh_token=" + refreshToken;
        String ret =  GetJsonDataFromUrl(url);
        UnityPlayer.UnitySendMessage("LuaRuntime","RefreshAccessToken",ret);

	}

    /**
     * 刷新或续期 access_token
     */
    public static void getUserInfo(String accessToken,String openID) {
        String url = WXGETUSER_URL + accessToken + "&openid="+openID;
        String ret =  GetJsonDataFromUrl(url);
        UnityPlayer.UnitySendMessage("LuaRuntime","OnGetUserInfo",ret);

	}
 
    // 通过网址请求数据
    public static String GetJsonDataFromUrl(String URL) 
    {
        HttpURLConnection conn = null;
        InputStream is = null;
        BufferedReader br = null;
        StringBuilder result = new StringBuilder();
        try {
            //创建远程url连接对象
            URL url = new URL(URL);
            //通过远程url连接对象打开一个连接，强转成HTTPURLConnection类
            conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            //设置连接超时时间和读取超时时间
            conn.setConnectTimeout(15000);
            conn.setReadTimeout(60000);
            conn.setRequestProperty("Accept", "application/json");
            //发送请求
            conn.connect();
            //通过conn取得输入流，并使用Reader读取
            if (200 == conn.getResponseCode()) {
                is = conn.getInputStream();
                br = new BufferedReader(new InputStreamReader(is, "UTF-8"));
                String line;
                while ((line = br.readLine()) != null) {
                    result.append(line);
                    System.out.println(line);
                }
            } else {
                System.out.println("ResponseCode is an error code:" + conn.getResponseCode());
            }
        } catch (MalformedURLException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            try {
                if (br != null) {
                    br.close();
                }
                if (is != null) {
                    is.close();
                }
            } catch (IOException ioe) {
                ioe.printStackTrace();
            }
            conn.disconnect();
        }
        return result.toString();
    }
}

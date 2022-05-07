package com.qq1798.buyu.wxapi;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.widget.Toast;

import com.tencent.mm.opensdk.openapi.IWXAPI;
import com.tencent.mm.opensdk.openapi.WXAPIFactory;
import com.tencent.mm.opensdk.openapi.IWXAPIEventHandler;
import com.tencent.mm.opensdk.constants.ConstantsAPI;
import com.tencent.mm.opensdk.modelbase.BaseReq;
import com.tencent.mm.opensdk.modelbase.BaseResp;
import com.tencent.mm.opensdk.modelmsg.SendAuth;

import com.unity3d.player.UnityPlayer;

import com.qq1798.buyu.Constants;

public class WXEntryActivity extends Activity implements IWXAPIEventHandler {
    private IWXAPI api;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
		//String text = "onCreate";
        //Toast.makeText(Constants.context, text, Toast.LENGTH_LONG).show();
        super.onCreate(savedInstanceState);
        api = WXAPIFactory.createWXAPI(Constants.context, Constants.APP_ID, false);
        api.handleIntent(getIntent(), this);
    }

    @Override
    protected void onNewIntent(Intent intent) {
		//String text = "onNewIntent";
        //Toast.makeText(Constants.context, text, Toast.LENGTH_LONG).show();
        super.onNewIntent(intent);
        setIntent(intent);
        api.handleIntent(intent, this);
    }

	@Override
    public void onReq(BaseReq baseReq) {
		//String text = "onReq";
        //Toast.makeText(Constants.context, text, Toast.LENGTH_LONG).show();
    }

    @Override
    public void onResp(BaseResp resp) {
		//String text = "onResp";
        //Toast.makeText(Constants.context, text, Toast.LENGTH_LONG).show();
        try {
            if(resp.getType() == 1) // 登录为1 分享为0
            {
                // 登录回调
                //String result;
                switch (resp.errCode) {
                    case BaseResp.ErrCode.ERR_OK:
                        SendAuth.Resp authResp = (SendAuth.Resp)resp;
                        UnityPlayer.UnitySendMessage("LuaRuntime","OnWechatAuth",authResp.code);
                        //result = "~~~授权成功!";
                        break;
                    case BaseResp.ErrCode.ERR_USER_CANCEL:
                        //result = "~~~取消授权";
                        UnityPlayer.UnitySendMessage("LuaRuntime","OnCancelAuth","");
                        break;
                    case BaseResp.ErrCode.ERR_AUTH_DENIED:
                        //result = "~~~拒绝授权";
                        UnityPlayer.UnitySendMessage("LuaRuntime","OnDeniedAuth","");
                        break;
                    default:
                        //result = "~~~错误码："+resp.errCode;
                        UnityPlayer.UnitySendMessage("LuaRuntime","OnWechatError",""+resp.errCode);
                        break;
                }
                //Toast.makeText(Constants.context,resp.errCode,Toast.LENGTH_LONG).show();
            }
            else 
            {
                // 分享回调
                switch (resp.errCode){
                    case BaseResp.ErrCode.ERR_OK:
                        Toast.makeText(WXEntryActivity.this, "分享成功", Toast.LENGTH_LONG).show();
                        break;
                    case BaseResp.ErrCode.ERR_USER_CANCEL:
                        Toast.makeText(WXEntryActivity.this, "分享取消", Toast.LENGTH_LONG).show();
                        break;
                    case BaseResp.ErrCode.ERR_AUTH_DENIED:
                        Toast.makeText(WXEntryActivity.this, "分享拒绝", Toast.LENGTH_LONG).show();
                        break;
                    default:

                        break;
                }
            }
            finish();

        }catch (Exception e){

        }
    }

}

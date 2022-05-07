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

import com.unity3d.player.UnityPlayer;

import com.qq1798.buyu.Constants;

public class WXPayEntryActivity extends Activity implements IWXAPIEventHandler {
    private IWXAPI api;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        api = WXAPIFactory.createWXAPI(Constants.context, Constants.APP_ID, false);
        api.handleIntent(getIntent(), this);
    }
    
    @Override
    protected void onNewIntent(Intent intent) {
        super.onNewIntent(intent);
        setIntent(intent);
        api.handleIntent(intent, this);
    }

	@Override
    public void onReq(BaseReq baseReq) {
        
    }

    @Override
    public void onResp(BaseResp resp) {
        try {
            //String result;
			if (resp.getType() == ConstantsAPI.COMMAND_PAY_BY_WX){
				switch(resp.errCode){
					case 0:
						//支付成功
						//result = "支付成功";
					break;
					case -1:
						//支付异常
						//result = "支付异常";
					break;
					case -2:
						//支付取消
						//result = "支付取消";
					break;
				}
			}
            finish();
        }catch (Exception e){
            
        }
    }
}

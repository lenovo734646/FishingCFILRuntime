#import "MyAppController.h" 
//static NSString *  WeiXinID;
// static NSString * WeiXinSecret;

IMPL_APP_CONTROLLER_SUBCLASS (MyAppController)
@implementation MyAppController 
+(instancetype) shareManager 
{ 
	static dispatch_once_t onceToken; 
	static MyAppController *instance; 
	dispatch_once(&onceToken, ^{ instance = [[MyAppController alloc] init]; }); 
	return instance;
} 
//重写微信方法（必要步骤）
- (BOOL)application:(UIApplication *)application handleOpenURL:(NSURL *)url {
    return  [WXApi handleOpenURL:url delegate:self];
}

//重写微信方法（必要步骤）
- (BOOL)application:(UIApplication *)application openURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication annotation:(id)annotation {
    return [WXApi handleOpenURL:url delegate:self];
}

- (BOOL)application:(UIApplication *)application continueUserActivity:(NSUserActivity *)userActivity restorationHandler:(void(^)(NSArray<id<UIUserActivityRestoring>>* __nullable restorableObjects))restorationHandler {
return [WXApi handleOpenUniversalLink:userActivity delegate:self];
}

- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {
    //向微信注册
    [WXApi registerApp:@"wxe5e490c947990833" universalLink:@"https://hlby.ttchongying.com/"];

	//向openinstall注册
	// [OpenInstallSDK initWithDelegate:[OpenInstallUnity3DCallBack defaultManager]];
    UnityRegisterAppDelegateListener(self);
    [super application:application didFinishLaunchingWithOptions:launchOptions];

	return YES;
}

-(void) onReq:(BaseReq *)req{}

-(void) onResp:(BaseResp *)resp{
	if([resp isKindOfClass:[SendAuthResp class]])
    {
        SendAuthResp *temp = (SendAuthResp*)resp;
        int errorCode = temp.errCode;
        switch (errorCode) {
            case 0:
                    printf("微信登录返回成功！");
					UnitySendMessage("Canvas(Clone)", "WechatAuth", [temp.code UTF8String]);
                    break;
            case -2:
                printf("用户取消");
                break;
            case -4:
                printf("用户拒绝授权");
                break;
            default:
                printf("登录失败");
                break;
        }
    }
    /*
     enum  WXErrCode {
     WXSuccess           = 0,    成功
     WXErrCodeCommon     = -1,  普通错误类型
     WXErrCodeUserCancel = -2,    用户点击取消并返回
     WXErrCodeSentFail   = -3,   发送失败
     WXErrCodeAuthDeny   = -4,    授权失败
     WXErrCodeUnsupport  = -5,   微信不支持
     };
     */
}


 //这是向微信终端注册你的appid 
 extern "C" 
 { 
 	//判断微信是否安装
 	void _iosLoginWeChat(char* appid, char* url)
 	{ 
		if ([WXApi isWXAppInstalled]) {
			// [self sendAuthRequest];
			// 登录 
			NSString* WeiXinID = [NSString stringWithUTF8String:appid];
			NSString* URL = [NSString stringWithUTF8String:url];
			// WeiXinSecret = [NSString stringWithUTF8String:secretKey];
			[WXApi registerApp:WeiXinID universalLink:URL];
			NSLog(@"向微信注册成功\n");
			   //构造SendAuthReq结构体
			SendAuthReq* req =[[SendAuthReq alloc]init];
			req.scope = @"snsapi_userinfo";
			req.state = @"wechat_wxx_sdk";
			//第三方向微信终端发送一个SendAuthReq消息结构
			[WXApi sendReq:req completion:nil];
		}
		else{
			NSLog(@"未安装微信。");
		}
 	}
	//复制到剪切板
 	void _iosSetClipboard(char * msg)
 	{
 		 UIPasteboard * pasteboard = [UIPasteboard generalPasteboard];
		 pasteboard.string = [NSString stringWithUTF8String:msg];
 	}
	
 }
@end

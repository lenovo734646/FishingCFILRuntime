#import <Foundation/Foundation.h> 
#import "WXApi.h" 
#import "UnityAppController.h"
#import <UIKit/UIKit.h>
// #import "OpenInstallSDK.h"
// #import "OpenInstallUnity3DCallBack.h"
#include "PluginBase/AppDelegateListener.h"
NS_ASSUME_NONNULL_BEGIN 

@interface MyAppController : UnityAppController<UIApplicationDelegate, WXApiDelegate,AppDelegateListener> 

+ (instancetype)shareManager; 

@end NS_ASSUME_NONNULL_END

//@interface AppDelegate : UIResponder<UIApplicationDelegate, WXApiDelegate>
//
//@property (strong, nonatomic) UIWindow *window;
//
//@end

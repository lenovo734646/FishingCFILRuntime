using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntimeCrossbindAdapter
{   
    public class ABSAnimationComponentAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(DG.Tweening.Core.ABSAnimationComponent);
            }
        }

        public override Type AdaptorType
        {
            get
            {
                return typeof(Adapter);
            }
        }

        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : DG.Tweening.Core.ABSAnimationComponent, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo mDOPlay_0 = new CrossBindingMethodInfo("DOPlay");
            CrossBindingMethodInfo mDOPlayBackwards_1 = new CrossBindingMethodInfo("DOPlayBackwards");
            CrossBindingMethodInfo mDOPlayForward_2 = new CrossBindingMethodInfo("DOPlayForward");
            CrossBindingMethodInfo mDOPause_3 = new CrossBindingMethodInfo("DOPause");
            CrossBindingMethodInfo mDOTogglePause_4 = new CrossBindingMethodInfo("DOTogglePause");
            CrossBindingMethodInfo mDORewind_5 = new CrossBindingMethodInfo("DORewind");
            CrossBindingMethodInfo mDORestart_6 = new CrossBindingMethodInfo("DORestart");
            CrossBindingMethodInfo<System.Boolean> mDORestart_7 = new CrossBindingMethodInfo<System.Boolean>("DORestart");
            CrossBindingMethodInfo mDOComplete_8 = new CrossBindingMethodInfo("DOComplete");
            CrossBindingMethodInfo mDOKill_9 = new CrossBindingMethodInfo("DOKill");

            bool isInvokingToString;
            ILTypeInstance instance;
            ILRuntime.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {

            }

            public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance { get { return instance; } }

            public override void DOPlay()
            {
                mDOPlay_0.Invoke(this.instance);
            }

            public override void DOPlayBackwards()
            {
                mDOPlayBackwards_1.Invoke(this.instance);
            }

            public override void DOPlayForward()
            {
                mDOPlayForward_2.Invoke(this.instance);
            }

            public override void DOPause()
            {
                mDOPause_3.Invoke(this.instance);
            }

            public override void DOTogglePause()
            {
                mDOTogglePause_4.Invoke(this.instance);
            }

            public override void DORewind()
            {
                mDORewind_5.Invoke(this.instance);
            }

            public override void DORestart()
            {
                mDORestart_6.Invoke(this.instance);
            }

            public override void DORestart(System.Boolean fromHere)
            {
                mDORestart_7.Invoke(this.instance, fromHere);
            }

            public override void DOComplete()
            {
                mDOComplete_8.Invoke(this.instance);
            }

            public override void DOKill()
            {
                mDOKill_9.Invoke(this.instance);
            }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    if (!isInvokingToString)
                    {
                        isInvokingToString = true;
                        string res = instance.ToString();
                        isInvokingToString = false;
                        return res;
                    }
                    else
                        return instance.Type.FullName;
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}


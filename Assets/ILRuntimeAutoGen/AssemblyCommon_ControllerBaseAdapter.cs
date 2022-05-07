using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntimeCrossbindAdapter
{   
    public class ControllerBaseAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(AssemblyCommon.ControllerBase);
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

        public class Adapter : AssemblyCommon.ControllerBase, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<System.String> mGetDebugInfo_0 = new CrossBindingFunctionInfo<System.String>("GetDebugInfo");
            CrossBindingMethodInfo mStart_1 = new CrossBindingMethodInfo("Start");
            CrossBindingMethodInfo mUpdate_2 = new CrossBindingMethodInfo("Update");
            CrossBindingMethodInfo mStop_3 = new CrossBindingMethodInfo("Stop");
            CrossBindingFunctionInfo<System.Boolean> mIsReady_4 = new CrossBindingFunctionInfo<System.Boolean>("IsReady");

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

            public override System.String GetDebugInfo()
            {
                if (mGetDebugInfo_0.CheckShouldInvokeBase(this.instance))
                    return base.GetDebugInfo();
                else
                    return mGetDebugInfo_0.Invoke(this.instance);
            }

            public override void Start()
            {
                if (mStart_1.CheckShouldInvokeBase(this.instance))
                    base.Start();
                else
                    mStart_1.Invoke(this.instance);
            }

            public override void Update()
            {
                if (mUpdate_2.CheckShouldInvokeBase(this.instance))
                    base.Update();
                else
                    mUpdate_2.Invoke(this.instance);
            }

            public override void Stop()
            {
                mStop_3.Invoke(this.instance);
            }

            public override System.Boolean IsReady()
            {
                if (mIsReady_4.CheckShouldInvokeBase(this.instance))
                    return base.IsReady();
                else
                    return mIsReady_4.Invoke(this.instance);
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


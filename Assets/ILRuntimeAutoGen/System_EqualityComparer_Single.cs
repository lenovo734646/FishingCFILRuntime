using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntimeCrossbindAdapter
{   
    public class EqualityComparer_1_SingleAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(System.Collections.Generic.EqualityComparer<System.Single>);
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

        public class Adapter : System.Collections.Generic.EqualityComparer<System.Single>, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<System.Single, System.Single, System.Boolean> mEquals_0 = new CrossBindingFunctionInfo<System.Single, System.Single, System.Boolean>("Equals");
            CrossBindingFunctionInfo<System.Single, System.Int32> mGetHashCode_1 = new CrossBindingFunctionInfo<System.Single, System.Int32>("GetHashCode");
            CrossBindingFunctionInfo<System.Object, System.Object, System.Boolean> mEquals_2 = new CrossBindingFunctionInfo<System.Object, System.Object, System.Boolean>("Equals");
            CrossBindingFunctionInfo<System.Object, System.Int32> mGetHashCode_3 = new CrossBindingFunctionInfo<System.Object, System.Int32>("GetHashCode");

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

            public override System.Boolean Equals(System.Single x, System.Single y)
            {
                return mEquals_0.Invoke(this.instance, x, y);
            }

            public override System.Int32 GetHashCode(System.Single obj)
            {
                return mGetHashCode_1.Invoke(this.instance, obj);
            }

            public System.Boolean Equals(System.Object x, System.Object y)
            {
                return mEquals_2.Invoke(this.instance, x, y);
            }

            public System.Int32 GetHashCode(System.Object obj)
            {
                return mGetHashCode_3.Invoke(this.instance, obj);
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


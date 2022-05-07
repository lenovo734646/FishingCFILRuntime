using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class AssemblyCommon_MsgPbBase_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(AssemblyCommon.MsgPbBase);
            args = new Type[]{typeof(AssemblyCommon.IProtoMessage)};
            method = type.GetMethod("SetProtoMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProtoMessage_0);

            field = type.GetField("content", flag);
            app.RegisterCLRFieldGetter(field, get_content_0);
            app.RegisterCLRFieldSetter(field, set_content_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_content_0, AssignFromStack_content_0);


        }


        static StackObject* SetProtoMessage_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.IProtoMessage @proto = (AssemblyCommon.IProtoMessage)typeof(AssemblyCommon.IProtoMessage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.MsgPbBase instance_of_this_method = (AssemblyCommon.MsgPbBase)typeof(AssemblyCommon.MsgPbBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProtoMessage(@proto);

            return __ret;
        }


        static object get_content_0(ref object o)
        {
            return ((AssemblyCommon.MsgPbBase)o).content;
        }

        static StackObject* CopyToStack_content_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.MsgPbBase)o).content;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_content_0(ref object o, object v)
        {
            ((AssemblyCommon.MsgPbBase)o).content = (System.Byte[])v;
        }

        static StackObject* AssignFromStack_content_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte[] @content = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((AssemblyCommon.MsgPbBase)o).content = @content;
            return ptr_of_this_method;
        }



    }
}

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
    unsafe class AssemblyCommon_MsgPbForm_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(AssemblyCommon.MsgPbForm);
            args = new Type[]{typeof(AssemblyCommon.BinaryStream)};
            method = type.GetMethod("Write", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Write_0);
            args = new Type[]{typeof(AssemblyCommon.BinaryStream)};
            method = type.GetMethod("Read", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Read_1);

            field = type.GetField("subCmd", flag);
            app.RegisterCLRFieldGetter(field, get_subCmd_0);
            app.RegisterCLRFieldSetter(field, set_subCmd_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_subCmd_0, AssignFromStack_subCmd_0);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Write_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream @stm = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.MsgPbForm instance_of_this_method = (AssemblyCommon.MsgPbForm)typeof(AssemblyCommon.MsgPbForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Write(@stm);

            return __ret;
        }

        static StackObject* Read_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream @stm = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.MsgPbForm instance_of_this_method = (AssemblyCommon.MsgPbForm)typeof(AssemblyCommon.MsgPbForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Read(@stm);

            return __ret;
        }


        static object get_subCmd_0(ref object o)
        {
            return ((AssemblyCommon.MsgPbForm)o).subCmd;
        }

        static StackObject* CopyToStack_subCmd_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.MsgPbForm)o).subCmd;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_subCmd_0(ref object o, object v)
        {
            ((AssemblyCommon.MsgPbForm)o).subCmd = (System.Int16)v;
        }

        static StackObject* AssignFromStack_subCmd_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int16 @subCmd = (short)ptr_of_this_method->Value;
            ((AssemblyCommon.MsgPbForm)o).subCmd = @subCmd;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new AssemblyCommon.MsgPbForm();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

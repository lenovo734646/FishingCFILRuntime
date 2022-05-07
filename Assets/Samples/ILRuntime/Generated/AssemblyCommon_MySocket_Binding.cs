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
    unsafe class AssemblyCommon_MySocket_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(AssemblyCommon.MySocket);

            field = type.GetField("encrypt", flag);
            app.RegisterCLRFieldGetter(field, get_encrypt_0);
            app.RegisterCLRFieldSetter(field, set_encrypt_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_encrypt_0, AssignFromStack_encrypt_0);
            field = type.GetField("useProtocolParser", flag);
            app.RegisterCLRFieldGetter(field, get_useProtocolParser_1);
            app.RegisterCLRFieldSetter(field, set_useProtocolParser_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_useProtocolParser_1, AssignFromStack_useProtocolParser_1);


        }



        static object get_encrypt_0(ref object o)
        {
            return ((AssemblyCommon.MySocket)o).encrypt;
        }

        static StackObject* CopyToStack_encrypt_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.MySocket)o).encrypt;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_encrypt_0(ref object o, object v)
        {
            ((AssemblyCommon.MySocket)o).encrypt = (AssemblyCommon.EncryptionSerivce)v;
        }

        static StackObject* AssignFromStack_encrypt_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            AssemblyCommon.EncryptionSerivce @encrypt = (AssemblyCommon.EncryptionSerivce)typeof(AssemblyCommon.EncryptionSerivce).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((AssemblyCommon.MySocket)o).encrypt = @encrypt;
            return ptr_of_this_method;
        }

        static object get_useProtocolParser_1(ref object o)
        {
            return ((AssemblyCommon.MySocket)o).useProtocolParser;
        }

        static StackObject* CopyToStack_useProtocolParser_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.MySocket)o).useProtocolParser;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_useProtocolParser_1(ref object o, object v)
        {
            ((AssemblyCommon.MySocket)o).useProtocolParser = (AssemblyCommon.MySocket.ProtocolParser)v;
        }

        static StackObject* AssignFromStack_useProtocolParser_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            AssemblyCommon.MySocket.ProtocolParser @useProtocolParser = (AssemblyCommon.MySocket.ProtocolParser)typeof(AssemblyCommon.MySocket.ProtocolParser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((AssemblyCommon.MySocket)o).useProtocolParser = @useProtocolParser;
            return ptr_of_this_method;
        }



    }
}

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
    unsafe class Google_Protobuf_CodedOutputStream_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Google.Protobuf.CodedOutputStream);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("WriteTag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteTag_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("WriteString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteString_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("WriteInt32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteInt32_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("WriteBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteBool_3);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("WriteDouble", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteDouble_4);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("WriteInt64", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteInt64_5);
            args = new Type[]{typeof(System.Action<Google.Protobuf.CodedOutputStream>)};
            method = type.GetMethod("WriteMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteMessage_6);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("WriteFixed32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteFixed32_7);
            args = new Type[]{typeof(System.Action<Google.Protobuf.CodedOutputStream>)};
            method = type.GetMethod("WriteRepeated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteRepeated_8);
            args = new Type[]{typeof(System.Byte[])};
            method = type.GetMethod("WriteBytes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteBytes_9);


        }


        static StackObject* WriteTag_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @tag = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteTag(@tag);

            return __ret;
        }

        static StackObject* WriteString_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteString(@value);

            return __ret;
        }

        static StackObject* WriteInt32_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteInt32(@value);

            return __ret;
        }

        static StackObject* WriteBool_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteBool(@value);

            return __ret;
        }

        static StackObject* WriteDouble_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @value = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteDouble(@value);

            return __ret;
        }

        static StackObject* WriteInt64_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @value = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteInt64(@value);

            return __ret;
        }

        static StackObject* WriteMessage_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Google.Protobuf.CodedOutputStream> @encoder = (System.Action<Google.Protobuf.CodedOutputStream>)typeof(System.Action<Google.Protobuf.CodedOutputStream>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteMessage(@encoder);

            return __ret;
        }

        static StackObject* WriteFixed32_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @value = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteFixed32(@value);

            return __ret;
        }

        static StackObject* WriteRepeated_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Google.Protobuf.CodedOutputStream> @encoder = (System.Action<Google.Protobuf.CodedOutputStream>)typeof(System.Action<Google.Protobuf.CodedOutputStream>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteRepeated(@encoder);

            return __ret;
        }

        static StackObject* WriteBytes_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] @value = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedOutputStream instance_of_this_method = (Google.Protobuf.CodedOutputStream)typeof(Google.Protobuf.CodedOutputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteBytes(@value);

            return __ret;
        }



    }
}

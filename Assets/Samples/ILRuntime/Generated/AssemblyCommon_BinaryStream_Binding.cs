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
    unsafe class AssemblyCommon_BinaryStream_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(AssemblyCommon.BinaryStream);
            args = new Type[]{};
            method = type.GetMethod("ClearUsedData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearUsedData_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetCurentWrite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCurentWrite_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("WriteInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteInt_2);
            args = new Type[]{};
            method = type.GetMethod("WriteDataLengthHeader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteDataLengthHeader_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetCurentRead", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCurentRead_4);
            args = new Type[]{};
            method = type.GetMethod("ReadInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadInt_5);
            args = new Type[]{};
            method = type.GetMethod("DataLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DataLeft_6);
            args = new Type[]{};
            method = type.GetMethod("buffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, buffer_7);
            args = new Type[]{typeof(System.Byte)};
            method = type.GetMethod("WriteByte", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteByte_8);

            args = new Type[]{typeof(System.Byte[]), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* ClearUsedData_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearUsedData();

            return __ret;
        }

        static StackObject* SetCurentWrite_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @to = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCurentWrite(@to);

            return __ret;
        }

        static StackObject* WriteInt_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @v = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteInt(@v);

            return __ret;
        }

        static StackObject* WriteDataLengthHeader_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteDataLengthHeader();

            return __ret;
        }

        static StackObject* SetCurentRead_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @to = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCurentRead(@to);

            return __ret;
        }

        static StackObject* ReadInt_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadInt();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* DataLeft_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DataLeft();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* buffer_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.buffer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WriteByte_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte @b = (byte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.BinaryStream instance_of_this_method = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteByte(@b);

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @len = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Byte[] @data = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new AssemblyCommon.BinaryStream(@data, @len);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @len = ptr_of_this_method->Value;


            var result_of_this_method = new AssemblyCommon.BinaryStream(@len);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

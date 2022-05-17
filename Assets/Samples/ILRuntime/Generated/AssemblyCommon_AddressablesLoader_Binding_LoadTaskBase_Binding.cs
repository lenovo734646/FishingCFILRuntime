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
    unsafe class AssemblyCommon_AddressablesLoader_Binding_LoadTaskBase_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(AssemblyCommon.AddressablesLoader.LoadTaskBase);
            args = new Type[]{};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_0);

            field = type.GetField("succeed", flag);
            app.RegisterCLRFieldGetter(field, get_succeed_0);
            app.RegisterCLRFieldSetter(field, set_succeed_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_succeed_0, AssignFromStack_succeed_0);
            field = type.GetField("data", flag);
            app.RegisterCLRFieldGetter(field, get_data_1);
            app.RegisterCLRFieldSetter(field, set_data_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_data_1, AssignFromStack_data_1);


        }


        static StackObject* Release_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.AddressablesLoader.LoadTaskBase instance_of_this_method = (AssemblyCommon.AddressablesLoader.LoadTaskBase)typeof(AssemblyCommon.AddressablesLoader.LoadTaskBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Release();

            return __ret;
        }


        static object get_succeed_0(ref object o)
        {
            return ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).succeed;
        }

        static StackObject* CopyToStack_succeed_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).succeed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_succeed_0(ref object o, object v)
        {
            ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).succeed = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_succeed_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @succeed = ptr_of_this_method->Value == 1;
            ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).succeed = @succeed;
            return ptr_of_this_method;
        }

        static object get_data_1(ref object o)
        {
            return ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).data;
        }

        static StackObject* CopyToStack_data_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).data;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_data_1(ref object o, object v)
        {
            ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).data = (System.String)v;
        }

        static StackObject* AssignFromStack_data_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((AssemblyCommon.AddressablesLoader.LoadTaskBase)o).data = @data;
            return ptr_of_this_method;
        }



    }
}

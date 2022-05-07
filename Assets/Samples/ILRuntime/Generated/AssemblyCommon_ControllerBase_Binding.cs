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
    unsafe class AssemblyCommon_ControllerBase_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(AssemblyCommon.ControllerBase);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_0);
            args = new Type[]{};
            method = type.GetMethod("Start", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Start_1);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_2);

            field = type.GetField("progress", flag);
            app.RegisterCLRFieldGetter(field, get_progress_0);
            app.RegisterCLRFieldSetter(field, set_progress_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_progress_0, AssignFromStack_progress_0);


        }


        static StackObject* Update_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.ControllerBase instance_of_this_method = (AssemblyCommon.ControllerBase)typeof(AssemblyCommon.ControllerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }

        static StackObject* Start_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.ControllerBase instance_of_this_method = (AssemblyCommon.ControllerBase)typeof(AssemblyCommon.ControllerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Start();

            return __ret;
        }

        static StackObject* Stop_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.ControllerBase instance_of_this_method = (AssemblyCommon.ControllerBase)typeof(AssemblyCommon.ControllerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }


        static object get_progress_0(ref object o)
        {
            return ((AssemblyCommon.ControllerBase)o).progress;
        }

        static StackObject* CopyToStack_progress_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((AssemblyCommon.ControllerBase)o).progress;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_progress_0(ref object o, object v)
        {
            ((AssemblyCommon.ControllerBase)o).progress = (AssemblyCommon.IShowDownloadProgress)v;
        }

        static StackObject* AssignFromStack_progress_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            AssemblyCommon.IShowDownloadProgress @progress = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((AssemblyCommon.ControllerBase)o).progress = @progress;
            return ptr_of_this_method;
        }



    }
}

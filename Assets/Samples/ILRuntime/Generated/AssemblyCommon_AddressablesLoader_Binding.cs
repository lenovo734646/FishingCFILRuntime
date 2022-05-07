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
    unsafe class AssemblyCommon_AddressablesLoader_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(AssemblyCommon.AddressablesLoader);
            args = new Type[]{};
            method = type.GetMethod("GetPlatformString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPlatformString_0);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;                    
            foreach(var m in type.GetMethods())
            {
                if(m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }
                    lst.Add(m);
                }
            }
            args = new Type[]{typeof(AssemblyCommon.AddressablesLoader.DownloadCatalog)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.IEnumerator<AssemblyCommon.AddressablesLoader.LoadTask<AssemblyCommon.AddressablesLoader.DownloadCatalog>>), typeof(System.String), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_1);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(AssemblyCommon.AddressablesLoader.DownloadDependency)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.IEnumerator<AssemblyCommon.AddressablesLoader.LoadTask<AssemblyCommon.AddressablesLoader.DownloadDependency>>), typeof(System.String), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_2);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(AssemblyCommon.AddressablesLoader.DownloadScene)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.IEnumerator<AssemblyCommon.AddressablesLoader.LoadTask<AssemblyCommon.AddressablesLoader.DownloadScene>>), typeof(System.String), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_3);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(UnityEngine.GameObject)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(System.Collections.Generic.IEnumerator<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.GameObject>>), typeof(System.String), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_4);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(UnityEngine.Material)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(void), typeof(System.String), typeof(System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Material>>), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_5);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(UnityEngine.GameObject)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(void), typeof(System.String), typeof(System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.GameObject>>), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_6);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(UnityEngine.Texture2D)};
            if (genericMethods.TryGetValue("LoadAsync", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(void), typeof(System.String), typeof(System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Texture2D>>), typeof(AssemblyCommon.IShowDownloadProgress), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, LoadAsync_7);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("WaitForAllTaskCompletion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitForAllTaskCompletion_8);

            field = type.GetField("usingUpdateUrl", flag);
            app.RegisterCLRFieldGetter(field, get_usingUpdateUrl_0);
            app.RegisterCLRFieldSetter(field, set_usingUpdateUrl_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_usingUpdateUrl_0, AssignFromStack_usingUpdateUrl_0);


        }


        static StackObject* GetPlatformString_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlatformString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadAsync_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoadAsync<AssemblyCommon.AddressablesLoader.DownloadCatalog>(@path, @ip, @data);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadAsync_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoadAsync<AssemblyCommon.AddressablesLoader.DownloadDependency>(@path, @ip, @data);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadAsync_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoadAsync<AssemblyCommon.AddressablesLoader.DownloadScene>(@path, @ip, @data);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadAsync_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoadAsync<UnityEngine.GameObject>(@path, @ip, @data);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadAsync_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Material>> @callback = (System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Material>>)typeof(System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Material>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadAsync<UnityEngine.Material>(@path, @callback, @ip, @data);

            return __ret;
        }

        static StackObject* LoadAsync_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.GameObject>> @callback = (System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.GameObject>>)typeof(System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.GameObject>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadAsync<UnityEngine.GameObject>(@path, @callback, @ip, @data);

            return __ret;
        }

        static StackObject* LoadAsync_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.IShowDownloadProgress @ip = (AssemblyCommon.IShowDownloadProgress)typeof(AssemblyCommon.IShowDownloadProgress).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Texture2D>> @callback = (System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Texture2D>>)typeof(System.Action<AssemblyCommon.AddressablesLoader.LoadTask<UnityEngine.Texture2D>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadAsync<UnityEngine.Texture2D>(@path, @callback, @ip, @data);

            return __ret;
        }

        static StackObject* WaitForAllTaskCompletion_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @timeout = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.AddressablesLoader instance_of_this_method = (AssemblyCommon.AddressablesLoader)typeof(AssemblyCommon.AddressablesLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WaitForAllTaskCompletion(@timeout);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_usingUpdateUrl_0(ref object o)
        {
            return AssemblyCommon.AddressablesLoader.usingUpdateUrl;
        }

        static StackObject* CopyToStack_usingUpdateUrl_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = AssemblyCommon.AddressablesLoader.usingUpdateUrl;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_usingUpdateUrl_0(ref object o, object v)
        {
            AssemblyCommon.AddressablesLoader.usingUpdateUrl = (System.String)v;
        }

        static StackObject* AssignFromStack_usingUpdateUrl_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @usingUpdateUrl = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            AssemblyCommon.AddressablesLoader.usingUpdateUrl = @usingUpdateUrl;
            return ptr_of_this_method;
        }



    }
}

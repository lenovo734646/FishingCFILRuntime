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
    unsafe class AssemblyCommon_NetManager_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(AssemblyCommon.NetManager);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_0);
            args = new Type[]{};
            method = type.GetMethod("Start", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Start_1);
            args = new Type[]{};
            method = type.GetMethod("sock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, sock_2);
            args = new Type[]{};
            method = type.GetMethod("IsWorking", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsWorking_3);
            args = new Type[]{typeof(System.EventHandler<AssemblyCommon.MySocket.SocketState>)};
            method = type.GetMethod("RegisterSockEventHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterSockEventHandler_4);
            args = new Type[]{typeof(System.EventHandler<AssemblyCommon.BinaryStream>)};
            method = type.GetMethod("RegisterRawDataHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterRawDataHandler_5);
            args = new Type[]{typeof(System.EventHandler<AssemblyCommon.BinaryStream>)};
            method = type.GetMethod("RemoveRawDataHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveRawDataHandler_6);
            args = new Type[]{typeof(System.EventHandler<AssemblyCommon.MySocket.SocketState>)};
            method = type.GetMethod("RemoveSockEventHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveSockEventHandler_7);
            args = new Type[]{typeof(AssemblyCommon.BinaryStream), typeof(System.Boolean)};
            method = type.GetMethod("SendMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendMessage_8);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_9);

            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.String, System.Int32>), typeof(System.Single), typeof(AssemblyCommon.MySocket.ProtocolParser)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Stop_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* Start_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Start();

            return __ret;
        }

        static StackObject* sock_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sock();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsWorking_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsWorking();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RegisterSockEventHandler_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<AssemblyCommon.MySocket.SocketState> @eventHandler = (System.EventHandler<AssemblyCommon.MySocket.SocketState>)typeof(System.EventHandler<AssemblyCommon.MySocket.SocketState>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterSockEventHandler(@eventHandler);

            return __ret;
        }

        static StackObject* RegisterRawDataHandler_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<AssemblyCommon.BinaryStream> @eventHandler = (System.EventHandler<AssemblyCommon.BinaryStream>)typeof(System.EventHandler<AssemblyCommon.BinaryStream>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterRawDataHandler(@eventHandler);

            return __ret;
        }

        static StackObject* RemoveRawDataHandler_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<AssemblyCommon.BinaryStream> @eventHandler = (System.EventHandler<AssemblyCommon.BinaryStream>)typeof(System.EventHandler<AssemblyCommon.BinaryStream>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveRawDataHandler(@eventHandler);

            return __ret;
        }

        static StackObject* RemoveSockEventHandler_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<AssemblyCommon.MySocket.SocketState> @eventHandler = (System.EventHandler<AssemblyCommon.MySocket.SocketState>)typeof(System.EventHandler<AssemblyCommon.MySocket.SocketState>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveSockEventHandler(@eventHandler);

            return __ret;
        }

        static StackObject* SendMessage_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @noEncrypt = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            AssemblyCommon.BinaryStream @stm = (AssemblyCommon.BinaryStream)typeof(AssemblyCommon.BinaryStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SendMessage(@stm, @noEncrypt);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Update_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.NetManager instance_of_this_method = (AssemblyCommon.NetManager)typeof(AssemblyCommon.NetManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            AssemblyCommon.MySocket.ProtocolParser @proto = (AssemblyCommon.MySocket.ProtocolParser)typeof(AssemblyCommon.MySocket.ProtocolParser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @timeOut = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<System.String, System.Int32> @hosts = (System.Collections.Generic.Dictionary<System.String, System.Int32>)typeof(System.Collections.Generic.Dictionary<System.String, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new AssemblyCommon.NetManager(@hosts, @timeOut, @proto);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

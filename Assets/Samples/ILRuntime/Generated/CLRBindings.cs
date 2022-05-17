using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {

//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            ILRuntime.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3> s_UnityEngine_Vector3_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2> s_UnityEngine_Vector2_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion> s_UnityEngine_Quaternion_Binding_Binder = null;

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_Type_Binding.Register(app);
            ProtoBuf_PType_Binding.Register(app);
            System_String_Binding.Register(app);
            Google_Protobuf_CodedOutputStream_Binding.Register(app);
            Google_Protobuf_CodedInputStream_Binding.Register(app);
            System_Collections_Generic_List_1_ILRuntimeCrossbindAdapter_IProtoMessageAdapter_Binding_Adapter_Binding.Register(app);
            System_Collections_Generic_List_1_ILRuntimeCrossbindAdapter_IProtoMessageAdapter_Binding_Adapter_Binding_Enumerator_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding_Enumerator_Binding.Register(app);
            AssemblyCommon_TimeCounter_Binding.Register(app);
            AssemblyCommon_ControllerBase_Binding.Register(app);
            AssemblyCommon_IShowDownloadProgress_Binding.Register(app);
            AssemblyCommon_Globals_Binding.Register(app);
            AssemblyCommon_NetManager_Binding.Register(app);
            System_Object_Binding.Register(app);
            AssemblyCommon_MyDebug_Binding.Register(app);
            AssemblyCommon_MySocket_Binding.Register(app);
            AssemblyCommon_EncryptionSerivce_Binding.Register(app);
            UnityEngine_WaitForSeconds_Binding.Register(app);
            System_Array_Binding.Register(app);
            System_Collections_IEnumerator_Binding.Register(app);
            System_Exception_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int64_Binding.Register(app);
            System_NotSupportedException_Binding.Register(app);
            System_Threading_Interlocked_Binding.Register(app);
            System_EventArgs_Binding.Register(app);
            System_EventHandler_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Texture2D_Binding.Register(app);
            System_Int64_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_Texture2D_Binding.Register(app);
            AssemblyCommon_AddressablesLoader_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_AssemblyCommon_AddressablesLoader_Binding_DownloadCatalog_Binding.Register(app);
            AssemblyCommon_AddressablesLoader_Binding_LoadTaskBase_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_AssemblyCommon_AddressablesLoader_Binding_DownloadDependency_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_AssemblyCommon_AddressablesLoader_Binding_DownloadScene_Binding.Register(app);
            AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_AssemblyCommon_AddressablesLoader_Binding_DownloadScene_Binding.Register(app);
            System_Activator_Binding.Register(app);
            UnityEngine_Networking_UnityWebRequest_Binding.Register(app);
            System_Char_Binding.Register(app);
            UnityEngine_Networking_DownloadHandler_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_ILRuntimeCrossbindAdapter_ControllerBaseAdapter_Binding_Adapter_Binding.Register(app);
            System_DateTime_Binding.Register(app);
            UnityEngine_Random_Binding.Register(app);
            System_Collections_Generic_List_1_ILRuntimeCrossbindAdapter_ControllerBaseAdapter_Binding_Adapter_Binding_Enumerator_Binding.Register(app);
            System_Text_Encoding_Binding.Register(app);
            LitJson_JsonMapper_Binding.Register(app);
            AssemblyCommon_BinaryStream_Binding.Register(app);
            AssemblyCommon_MsgJsonForm_Binding.Register(app);
            AssemblyCommon_DictionaryCached_2_Int32_ILTypeInstance_Binding.Register(app);
            AssemblyCommon_DictionaryCached_2_Type_ILTypeInstance_Binding.Register(app);
            AssemblyCommon_MsgPbForm_Binding.Register(app);
            AssemblyCommon_MsgPbBase_Binding.Register(app);
            AssemblyCommon_MsgPbFormStringHeader_Binding.Register(app);
            System_Collections_Generic_List_1_KeyValuePair_2_Type_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Type_ILTypeInstance_Binding.Register(app);
            System_Action_1_IProtoMessage_Binding.Register(app);
            System_Collections_Generic_List_1_KeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Action_1_ILTypeInstance_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            System_EventHandler_1_ILTypeInstance_Binding.Register(app);
            System_Byte_Binding.Register(app);
            AssemblyCommon_IProtoMessage_Binding.Register(app);
            System_NotImplementedException_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_String_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_UI_InputField_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            UnityEngine_Events_UnityEvent_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_UI_Slider_Binding.Register(app);
            UnityEngine_UI_Toggle_Binding.Register(app);
            UnityEngine_Events_UnityEvent_1_Boolean_Binding.Register(app);
            UnityEngine_Events_UnityEvent_1_Single_Binding.Register(app);
            System_Collections_Generic_List_1_AssemblyCommon_AddressablesLoader_Binding_LoadTaskBase_Binding.Register(app);
            System_Collections_Generic_List_1_AssemblyCommon_AddressablesLoader_Binding_LoadTaskBase_Binding_Enumerator_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            System_Collections_Generic_List_1_GameObject_Binding.Register(app);
            System_Collections_Generic_List_1_GameObject_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_GameObject_Binding.Register(app);
            AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_GameObject_Binding.Register(app);
            System_Action_1_GameObject_Binding.Register(app);
            System_WeakReference_1_ILRuntimeCrossbindAdapter_ControllerBaseAdapter_Binding_Adapter_Binding.Register(app);
            System_Action_Binding.Register(app);
            AssemblyCommon_Co_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            DG_Tweening_ShortcutExtensions_Binding.Register(app);
            UnityEngine_Events_UnityEventBase_Binding.Register(app);
            MiniJSON_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            TMPro_TMP_Text_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int32_Binding.Register(app);
            AssemblyCommon_AddressablesLoader_Binding_LoadTask_1_Material_Binding.Register(app);
            UnityEngine_Renderer_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            DG_Tweening_TweenExtensions_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            Spine_Unity_SkeletonGraphic_Binding.Register(app);
            Spine_AnimationState_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            System_Single_Binding.Register(app);
            DG_Tweening_TweenSettingsExtensions_Binding.Register(app);
            UnityEngine_Mathf_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_Enumerator_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            s_UnityEngine_Vector3_Binding_Binder = null;
            s_UnityEngine_Vector2_Binding_Binder = null;
            s_UnityEngine_Quaternion_Binding_Binder = null;
        }
    }
}

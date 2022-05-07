#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
using ILRuntimeCrossbindAdapter;

[System.Reflection.Obfuscation(Exclude = true)]
public class ILRuntimeCrossBinding
{
   [MenuItem("ILRuntime/生成跨域继承适配器")]
    static void GenerateCrossbindAdapter()
    {
        //由于跨域继承特殊性太多，自动生成无法实现完全无副作用生成，所以这里提供的代码自动生成主要是给大家生成个初始模版，简化大家的工作
        //大多数情况直接使用自动生成的模版即可，如果遇到问题可以手动去修改生成后的文件，因此这里需要大家自行处理是否覆盖的问题

        using(System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/DF_Wweening_Core_ABSAnimationComponentAdapter.cs"))
        {
            sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(DG.Tweening.Core.ABSAnimationComponent), "ILRuntimeCrossbindAdapter"));
        }

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_EventArgsAdapter.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(System.EventArgs), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/AssemblyCommon_IShowDownloadProgress.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(AssemblyCommon.IShowDownloadProgress), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/CustomYieldInstructionAdapter.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(CustomYieldInstruction), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/AssemblyCommon_ControllerBaseAdapter.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(AssemblyCommon.ControllerBase), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_IEquatable_ILTypeInstance.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(IEquatable<ILRuntime.Runtime.Intepreter.ILTypeInstance>), "ILRuntimeCrossbindAdapter"));
		}
		
		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_EqualityComparer_Double.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(EqualityComparer<Double>), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_EqualityComparer_Single.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(EqualityComparer<Single>), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_EqualityComparer_Null_Double.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(EqualityComparer<System.Nullable<Double>>), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_EqualityComparer_Null_Single.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(EqualityComparer<System.Nullable<Single>>), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/System_IComparable_ILTypeInstance.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(IComparable<ILRuntime.Runtime.Intepreter.ILTypeInstance>), "ILRuntimeCrossbindAdapter"));
		}

		using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Assets/ILRuntimeAutoGen/IProtoMessage_Adapter.cs")) {
			sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof(AssemblyCommon.IProtoMessage), "ILRuntimeCrossbindAdapter"));
		}


		AssetDatabase.Refresh();
    }
}
#endif

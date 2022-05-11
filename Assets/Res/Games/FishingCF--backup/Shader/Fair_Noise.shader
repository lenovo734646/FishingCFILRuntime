Shader "Zhuyue/class2"
{
	Properties
	{
		_Fire_mask("Fire_mask", 2D) = "white" {}
		[HDR]_Color0("Color 0", Color) = (1,1,1,0)
		_Panner_01("Panner_01", Vector) = (0,0,0,0)
		_Panner_02("Panner_02", Vector) = (0,0,0,0)
		_Noisescale("Noisescale", Float) = 0
		_Noiseqiangdu("Noiseqiangdu", Range( 0 , 1)) = 0.3
		_AngleOffset("AngleOffset", Float) = 0
		_VoronoiNode_celldensity("VoronoiNode_celldensity", Float) = 0
		_Power("Power", Float) = 0
		_Fireqiangdu("Fireqiangdu", Float) = 0
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Transparent"  "Queue" = "Transparent+0" "IgnoreProjector" = "True" "IsEmissive" = "true"  }
		Cull Back
		CGINCLUDE
		#include "UnityPBSLighting.cginc"
		#include "UnityShaderVariables.cginc"
		#include "Lighting.cginc"
		#pragma target 3.0
		struct Input
		{
			float2 uv_texcoord;
		};

		struct SurfaceOutputCustomLightingCustom
		{
			half3 Albedo;
			half3 Normal;
			half3 Emission;
			half Metallic;
			half Smoothness;
			half Occlusion;
			half Alpha;
			Input SurfInput;
			UnityGIInput GIData;
		};

		uniform float4 _Color0;
		uniform sampler2D _Fire_mask;
		uniform float2 _Panner_01;
		uniform float _Noisescale;
		uniform float _Noiseqiangdu;
		uniform float _Fireqiangdu;
		uniform float2 _Panner_02;
		uniform float _AngleOffset;
		uniform float _VoronoiNode_celldensity;
		uniform float _Power;


		float2 unity_gradientNoise_dir( float2 p )
		{
			    p = p % 289;
			    float x = (34 * p.x + 1) * p.x % 289 + p.y;
			    x = (34 * x + 1) * x % 289;
			    x = frac(x / 41) * 2 - 1;
			    return normalize(float2(x - floor(x + 0.5), abs(x) - 0.5));
		}


		float unity_gradientNoise( float2 p )
		{
			    float2 ip = floor(p);
			    float2 fp = frac(p);
			    float d00 = dot(unity_gradientNoise_dir(ip), fp);
			    float d01 = dot(unity_gradientNoise_dir(ip + float2(0, 1)), fp - float2(0, 1));
			    float d10 = dot(unity_gradientNoise_dir(ip + float2(1, 0)), fp - float2(1, 0));
			    float d11 = dot(unity_gradientNoise_dir(ip + float2(1, 1)), fp - float2(1, 1));
			    fp = fp * fp * fp * (fp * (fp * 6 - 15) + 10);
			    return lerp(lerp(d00, d01, fp.y), lerp(d10, d11, fp.y), fp.x);
		}


		void Unity_GradientNoise_float( float2 UV , float Scale , out float Out )
		{
			 Out = unity_gradientNoise(UV * Scale) + 0.5;
		}


		float2 unity_voronoi_noise_randomVector( float2 UV , float offset )
		{
			float2x2 m = float2x2(15.27, 47.63, 99.41, 89.98);
			    UV = frac(sin(mul(UV, m)) * 46839.32);
			    return float2(sin(UV.y*+offset)*0.5+0.5, cos(UV.x*offset)*0.5+0.5);
		}


		inline half4 LightingStandardCustomLighting( inout SurfaceOutputCustomLightingCustom s, half3 viewDir, UnityGI gi )
		{
			UnityGIInput data = s.GIData;
			Input i = s.SurfInput;
			half4 c = 0;
			float2 TexUV22 = i.uv_texcoord;
			float localUnity_GradientNoise_float3_g2 = ( 0.0 );
			float2 panner10 = ( 1.0 * _Time.y * _Panner_01 + TexUV22);
			float2 UV3_g2 = panner10;
			float Scale3_g2 = _Noisescale;
			float Out3_g2 = 0;
			 Out3_g2 = unity_gradientNoise(UV3_g2 * Scale3_g2) + 0.5;
			float temp_output_20_0 = Out3_g2;
			float2 temp_cast_2 = (temp_output_20_0).xx;
			float2 lerpResult12 = lerp( TexUV22 , temp_cast_2 , _Noiseqiangdu);
			float2 Firemask27 = lerpResult12;
			float4 tex2DNode8 = tex2D( _Fire_mask, Firemask27 );
			float localUnity_Voronoi_float2_g3 = ( 0.0 );
			float2 panner34 = ( 1.0 * _Time.y * _Panner_02 + TexUV22);
			float2 UV2_g3 = panner34;
			float AngleOffset2_g3 = _AngleOffset;
			float CellDensity2_g3 = _VoronoiNode_celldensity;
			float Out2_g3 = 0;
			float Cells2_g3 = 0;
			 float2 g = floor(UV2_g3 * CellDensity2_g3);
			    float2 f = frac(UV2_g3 * CellDensity2_g3);
			    float t = 8.0;
			    float3 res = float3(8.0, 0.0, 0.0);
			    for(int y=-1; y<=1; y++)
			    {
			        for(int x=-1; x<=1; x++)
			        {
			            float2 lattice = float2(x,y);
			            float2 offset = unity_voronoi_noise_randomVector(lattice + g, AngleOffset2_g3);
			            float d = distance(lattice + offset, f);
			            if(d < res.x)
			            {
			                res = float3(d, offset.x, offset.y);
			                Out2_g3 = res.x;
			                Cells2_g3 = res.y;
			            }
			        }
			    }
			float Grandnoise39 = temp_output_20_0;
			float starmask48 = ( pow( Out2_g3 , _Power ) * Grandnoise39 );
			float clampResult19 = clamp( ( tex2DNode8.r * starmask48 ) , 0.0 , 1.0 );
			c.rgb = 0;
			c.a = clampResult19;
			return c;
		}

		inline void LightingStandardCustomLighting_GI( inout SurfaceOutputCustomLightingCustom s, UnityGIInput data, inout UnityGI gi )
		{
			s.GIData = data;
		}

		void surf( Input i , inout SurfaceOutputCustomLightingCustom o )
		{
			o.SurfInput = i;
			float2 TexUV22 = i.uv_texcoord;
			float localUnity_GradientNoise_float3_g2 = ( 0.0 );
			float2 panner10 = ( 1.0 * _Time.y * _Panner_01 + TexUV22);
			float2 UV3_g2 = panner10;
			float Scale3_g2 = _Noisescale;
			float Out3_g2 = 0;
			 Out3_g2 = unity_gradientNoise(UV3_g2 * Scale3_g2) + 0.5;
			float temp_output_20_0 = Out3_g2;
			float2 temp_cast_0 = (temp_output_20_0).xx;
			float2 lerpResult12 = lerp( TexUV22 , temp_cast_0 , _Noiseqiangdu);
			float2 Firemask27 = lerpResult12;
			float4 tex2DNode8 = tex2D( _Fire_mask, Firemask27 );
			o.Emission = ( ( _Color0 * tex2DNode8.r ) * _Fireqiangdu ).rgb;
		}

		ENDCG
		CGPROGRAM
		#pragma surface surf StandardCustomLighting alpha:fade keepalpha fullforwardshadows 

		ENDCG
		Pass
		{
			Name "ShadowCaster"
			Tags{ "LightMode" = "ShadowCaster" }
			ZWrite On
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 3.0
			#pragma multi_compile_shadowcaster
			#pragma multi_compile UNITY_PASS_SHADOWCASTER
			#pragma skip_variants FOG_LINEAR FOG_EXP FOG_EXP2
			#include "HLSLSupport.cginc"
			#if ( SHADER_API_D3D11 || SHADER_API_GLCORE || SHADER_API_GLES3 || SHADER_API_METAL || SHADER_API_VULKAN )
				#define CAN_SKIP_VPOS
			#endif
			#include "UnityCG.cginc"
			#include "Lighting.cginc"
			#include "UnityPBSLighting.cginc"
			sampler3D _DitherMaskLOD;
			struct v2f
			{
				V2F_SHADOW_CASTER;
				float2 customPack1 : TEXCOORD1;
				float3 worldPos : TEXCOORD2;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};
			v2f vert( appdata_full v )
			{
				v2f o;
				UNITY_SETUP_INSTANCE_ID( v );
				UNITY_INITIALIZE_OUTPUT( v2f, o );
				UNITY_TRANSFER_INSTANCE_ID( v, o );
				Input customInputData;
				float3 worldPos = mul( unity_ObjectToWorld, v.vertex ).xyz;
				half3 worldNormal = UnityObjectToWorldNormal( v.normal );
				o.customPack1.xy = customInputData.uv_texcoord;
				o.customPack1.xy = v.texcoord;
				o.worldPos = worldPos;
				TRANSFER_SHADOW_CASTER_NORMALOFFSET( o )
				return o;
			}
			half4 frag( v2f IN
			#if !defined( CAN_SKIP_VPOS )
			, UNITY_VPOS_TYPE vpos : VPOS
			#endif
			) : SV_Target
			{
				UNITY_SETUP_INSTANCE_ID( IN );
				Input surfIN;
				UNITY_INITIALIZE_OUTPUT( Input, surfIN );
				surfIN.uv_texcoord = IN.customPack1.xy;
				float3 worldPos = IN.worldPos;
				half3 worldViewDir = normalize( UnityWorldSpaceViewDir( worldPos ) );
				SurfaceOutputCustomLightingCustom o;
				UNITY_INITIALIZE_OUTPUT( SurfaceOutputCustomLightingCustom, o )
				surf( surfIN, o );
				UnityGI gi;
				UNITY_INITIALIZE_OUTPUT( UnityGI, gi );
				o.Alpha = LightingStandardCustomLighting( o, worldViewDir, gi ).a;
				#if defined( CAN_SKIP_VPOS )
				float2 vpos = IN.pos;
				#endif
				half alphaRef = tex3D( _DitherMaskLOD, float3( vpos.xy * 0.25, o.Alpha * 0.9375 ) ).a;
				clip( alphaRef - 0.01 );
				SHADOW_CASTER_FRAGMENT( IN )
			}
			ENDCG
		}
	}
	Fallback "Diffuse"
}
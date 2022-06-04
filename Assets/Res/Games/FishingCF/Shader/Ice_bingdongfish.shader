// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:34869,y:32279,varname:node_9361,prsc:2|custl-5117-OUT,clip-554-OUT;n:type:ShaderForge.SFN_Tex2d,id:851,x:33192,y:32537,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:_Diffuse,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d9ccfbbe2237e604db75df127135471a,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7625,x:31931,y:32875,ptovrint:False,ptlb:Tex_ice,ptin:_Tex_ice,varname:_Tex_ice,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:09fc4a5ee3bc0ea4fa18bbaf8d569f76,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Power,id:4848,x:32643,y:32773,varname:node_4848,prsc:2|VAL-3007-OUT,EXP-7521-OUT;n:type:ShaderForge.SFN_Multiply,id:5745,x:32553,y:33344,varname:node_5745,prsc:2|A-851-RGB,B-4181-OUT;n:type:ShaderForge.SFN_Add,id:5307,x:32969,y:32810,varname:node_5307,prsc:2|A-4848-OUT,B-5745-OUT;n:type:ShaderForge.SFN_Slider,id:4181,x:32096,y:33438,ptovrint:False,ptlb:Ice_texglow,ptin:_Ice_texglow,varname:_Ice_texglow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7292595,max:2;n:type:ShaderForge.SFN_Multiply,id:3330,x:32832,y:33060,varname:node_3330,prsc:2|A-851-RGB,B-3150-OUT;n:type:ShaderForge.SFN_Slider,id:3150,x:32129,y:32699,ptovrint:False,ptlb:Tex_glow,ptin:_Tex_glow,varname:_Tex_glow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.19646,max:2;n:type:ShaderForge.SFN_Multiply,id:6227,x:32666,y:32246,varname:node_6227,prsc:2|A-851-RGB,B-5674-OUT,C-297-RGB;n:type:ShaderForge.SFN_Slider,id:5674,x:32039,y:32080,ptovrint:False,ptlb:hit_color_glow,ptin:_hit_color_glow,varname:_hit_color_glow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:2;n:type:ShaderForge.SFN_Color,id:297,x:32250,y:32186,ptovrint:False,ptlb:hit_color,ptin:_hit_color,varname:_hit_color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_SwitchProperty,id:3036,x:33117,y:33076,ptovrint:False,ptlb:Texandice,ptin:_Texandice,varname:_Texandice,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3330-OUT,B-5307-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:3411,x:33729,y:32852,ptovrint:False,ptlb:Hit,ptin:_Hit,varname:_Hit,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3036-OUT,B-6227-OUT;n:type:ShaderForge.SFN_Multiply,id:3007,x:32558,y:33039,varname:node_3007,prsc:2|A-7625-RGB,B-435-RGB,C-4590-OUT;n:type:ShaderForge.SFN_Color,id:435,x:32018,y:33141,ptovrint:False,ptlb:Ice_color,ptin:_Ice_color,varname:_Ice_color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:4590,x:32253,y:33270,ptovrint:False,ptlb:Ice_glow,ptin:_Ice_glow,varname:_Ice_glow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Slider,id:7521,x:32173,y:32866,ptovrint:False,ptlb:Ice_duibidu,ptin:_Ice_duibidu,varname:_Ice_duibidu,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:4;n:type:ShaderForge.SFN_Tex2d,id:7778,x:33655,y:32388,ptovrint:False,ptlb:xiaosanmask,ptin:_xiaosanmask,varname:_xiaosanmask,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f53d713c153e44346896e27a87d775a6,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:554,x:33916,y:32536,varname:node_554,prsc:2|A-7778-R,B-1362-OUT;n:type:ShaderForge.SFN_Slider,id:1362,x:33509,y:32698,ptovrint:False,ptlb:xiaosan,ptin:_xiaosan,varname:_xiaosan,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:5;n:type:ShaderForge.SFN_Step,id:8071,x:34120,y:32590,varname:node_8071,prsc:2|A-554-OUT,B-5332-OUT;n:type:ShaderForge.SFN_Vector1,id:5332,x:33916,y:32730,varname:node_5332,prsc:2,v1:0.53;n:type:ShaderForge.SFN_Step,id:3194,x:34099,y:32761,varname:node_3194,prsc:2|A-9615-OUT,B-554-OUT;n:type:ShaderForge.SFN_Vector1,id:9615,x:33916,y:32852,varname:node_9615,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:6549,x:34129,y:32958,varname:node_6549,prsc:2|A-8071-OUT,B-3194-OUT;n:type:ShaderForge.SFN_Add,id:5117,x:34398,y:32360,varname:node_5117,prsc:2|A-3411-OUT,B-3189-OUT;n:type:ShaderForge.SFN_Multiply,id:3189,x:34477,y:33154,varname:node_3189,prsc:2|A-9922-OUT,B-7335-RGB;n:type:ShaderForge.SFN_Color,id:7335,x:34177,y:33173,ptovrint:False,ptlb:xiaosancolor,ptin:_xiaosancolor,varname:_xiaosancolor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.2939665,c3:0,c4:1;n:type:ShaderForge.SFN_Clamp01,id:5746,x:34407,y:32808,varname:node_5746,prsc:2|IN-6549-OUT;n:type:ShaderForge.SFN_RemapRange,id:9922,x:34407,y:33007,varname:node_9922,prsc:2,frmn:0,frmx:1,tomn:0,tomx:1|IN-5746-OUT;proporder:3411-3036-851-7625-4181-4590-7521-3150-5674-435-297-7778-1362-7335;pass:END;sub:END;*/

Shader "Shader Forge/ICE" {
    Properties {
        [MaterialToggle] _Hit ("Hit", Float ) = 0
        [MaterialToggle] _Texandice ("Texandice", Float ) = 0
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Tex_ice ("Tex_ice", 2D) = "white" {}
        _Ice_texglow ("Ice_texglow", Range(0, 2)) = 0.7292595
        _Ice_glow ("Ice_glow", Range(0, 2)) = 1
        _Ice_duibidu ("Ice_duibidu", Range(0, 4)) = 2
        _Tex_glow ("Tex_glow", Range(0, 2)) = 1.19646
        _hit_color_glow ("hit_color_glow", Range(0, 2)) = 2
        _Ice_color ("Ice_color", Color) = (1,1,1,1)
        _hit_color ("hit_color", Color) = (1,0,0,1)
        _xiaosanmask ("xiaosanmask", 2D) = "white" {}
        _xiaosan ("xiaosan", Range(0, 5)) = 5
        _xiaosancolor ("xiaosancolor", Color) = (1,0.2939665,0,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Tex_ice; uniform float4 _Tex_ice_ST;
            uniform float _Ice_texglow;
            uniform float _Tex_glow;
            uniform float _hit_color_glow;
            uniform float4 _hit_color;
            uniform fixed _Texandice;
            uniform fixed _Hit;
            uniform float4 _Ice_color;
            uniform float _Ice_glow;
            uniform float _Ice_duibidu;
            uniform sampler2D _xiaosanmask; uniform float4 _xiaosanmask_ST;
            uniform float _xiaosan;
            uniform float4 _xiaosancolor;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 _xiaosanmask_var = tex2D(_xiaosanmask,TRANSFORM_TEX(i.uv0, _xiaosanmask));
                float node_554 = (_xiaosanmask_var.r*_xiaosan);
                clip(node_554 - 0.5);
////// Lighting:
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float4 _Tex_ice_var = tex2D(_Tex_ice,TRANSFORM_TEX(i.uv0, _Tex_ice));
                float3 finalColor = (lerp( lerp( (_Diffuse_var.rgb*_Tex_glow), (pow((_Tex_ice_var.rgb*_Ice_color.rgb*_Ice_glow),_Ice_duibidu)+(_Diffuse_var.rgb*_Ice_texglow)), _Texandice ), (_Diffuse_var.rgb*_hit_color_glow*_hit_color.rgb), _Hit )+((saturate((step(node_554,0.53)*step(0.5,node_554)))*1.0+0.0)*_xiaosancolor.rgb));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _xiaosanmask; uniform float4 _xiaosanmask_ST;
            uniform float _xiaosan;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 _xiaosanmask_var = tex2D(_xiaosanmask,TRANSFORM_TEX(i.uv0, _xiaosanmask));
                float node_554 = (_xiaosanmask_var.r*_xiaosan);
                clip(node_554 - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

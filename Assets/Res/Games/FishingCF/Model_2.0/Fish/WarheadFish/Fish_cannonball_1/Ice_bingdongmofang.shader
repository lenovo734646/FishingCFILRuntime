// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33722,y:32576,varname:node_9361,prsc:2|custl-3411-OUT,voffset-7888-OUT;n:type:ShaderForge.SFN_Tex2d,id:851,x:31794,y:32221,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:_Diffuse,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d4d1b17da94cd944583445944ad24091,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7625,x:32476,y:32866,ptovrint:False,ptlb:Tex_ice,ptin:_Tex_ice,varname:_Tex_ice,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:09fc4a5ee3bc0ea4fa18bbaf8d569f76,ntxv:0,isnm:False|UVIN-1031-UVOUT;n:type:ShaderForge.SFN_Parallax,id:1031,x:32188,y:32878,varname:node_1031,prsc:2|HEI-3598-OUT,DEP-3269-OUT;n:type:ShaderForge.SFN_Power,id:4848,x:32781,y:32884,varname:node_4848,prsc:2|VAL-3007-OUT,EXP-7521-OUT;n:type:ShaderForge.SFN_Multiply,id:5745,x:32577,y:32742,varname:node_5745,prsc:2|A-8165-OUT,B-4181-OUT;n:type:ShaderForge.SFN_Add,id:5307,x:32974,y:32765,varname:node_5307,prsc:2|A-4848-OUT,B-5745-OUT;n:type:ShaderForge.SFN_Slider,id:4181,x:32214,y:33586,ptovrint:False,ptlb:Ice_texglow,ptin:_Ice_texglow,varname:_Ice_texglow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7292595,max:2;n:type:ShaderForge.SFN_Multiply,id:3330,x:32794,y:32614,varname:node_3330,prsc:2|A-8165-OUT,B-3150-OUT;n:type:ShaderForge.SFN_Slider,id:3150,x:32129,y:32699,ptovrint:False,ptlb:Tex_glow,ptin:_Tex_glow,varname:_Tex_glow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.19646,max:2;n:type:ShaderForge.SFN_Multiply,id:6227,x:32666,y:32246,varname:node_6227,prsc:2|A-851-RGB,B-5674-OUT,C-297-RGB;n:type:ShaderForge.SFN_Slider,id:5674,x:32039,y:32080,ptovrint:False,ptlb:hit_color_glow,ptin:_hit_color_glow,varname:_hit_color_glow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:2;n:type:ShaderForge.SFN_Color,id:297,x:32250,y:32186,ptovrint:False,ptlb:hit_color,ptin:_hit_color,varname:_hit_color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_SwitchProperty,id:3036,x:33120,y:33091,ptovrint:False,ptlb:Texandice,ptin:_Texandice,varname:_Texandice,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3330-OUT,B-5307-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:3411,x:33266,y:32807,ptovrint:False,ptlb:Hit,ptin:_Hit,varname:_Hit,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3036-OUT,B-6227-OUT;n:type:ShaderForge.SFN_NormalVector,id:7026,x:32590,y:33641,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:6590,x:33048,y:33290,varname:node_6590,prsc:2|A-7026-OUT,B-6978-OUT;n:type:ShaderForge.SFN_Slider,id:6978,x:32907,y:33611,ptovrint:False,ptlb:tuqi,ptin:_tuqi,varname:_tuqi,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.003143363,max:0.1;n:type:ShaderForge.SFN_Multiply,id:3007,x:32632,y:33029,varname:node_3007,prsc:2|A-7625-RGB,B-435-RGB,C-4590-OUT;n:type:ShaderForge.SFN_Color,id:435,x:32240,y:33087,ptovrint:False,ptlb:Ice_color,ptin:_Ice_color,varname:_Ice_color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:4590,x:32382,y:33196,ptovrint:False,ptlb:Ice_glow,ptin:_Ice_glow,varname:_Ice_glow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_SwitchProperty,id:7888,x:33460,y:33189,ptovrint:False,ptlb:Vertex_offset,ptin:_Vertex_offset,varname:_Vertex_offset,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-2413-OUT,B-6590-OUT;n:type:ShaderForge.SFN_Vector1,id:2413,x:33292,y:33140,varname:node_2413,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:3269,x:31952,y:33387,ptovrint:False,ptlb:Dep,ptin:_Dep,varname:_Dep,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:1;n:type:ShaderForge.SFN_Slider,id:7521,x:32214,y:33489,ptovrint:False,ptlb:Ice_duibidu,ptin:_Ice_duibidu,varname:_Ice_duibidu,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:4;n:type:ShaderForge.SFN_Vector1,id:3598,x:31968,y:32914,varname:node_3598,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:8165,x:32094,y:32439,varname:node_8165,prsc:2|A-851-RGB,B-9592-OUT,C-7465-OUT;n:type:ShaderForge.SFN_Multiply,id:9592,x:31712,y:32460,varname:node_9592,prsc:2|A-2662-R,B-3543-OUT;n:type:ShaderForge.SFN_Tex2d,id:2662,x:30764,y:32432,ptovrint:False,ptlb:mask_rgb,ptin:_mask_rgb,varname:_mask_rgb,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cb227b7ec9530fc419da0eb9c93af734,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Time,id:3687,x:30607,y:32822,varname:node_3687,prsc:2;n:type:ShaderForge.SFN_Sin,id:8724,x:31301,y:32956,varname:node_8724,prsc:2|IN-2211-OUT;n:type:ShaderForge.SFN_Multiply,id:2211,x:31055,y:32930,varname:node_2211,prsc:2|A-3687-T,B-2006-OUT;n:type:ShaderForge.SFN_Slider,id:2006,x:30607,y:33070,ptovrint:False,ptlb:shanguangspeed,ptin:_shanguangspeed,varname:_shanguangspeed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5.426485,max:10;n:type:ShaderForge.SFN_Multiply,id:7371,x:31566,y:33000,varname:node_7371,prsc:2|A-8724-OUT,B-5772-RGB,C-6347-OUT;n:type:ShaderForge.SFN_Color,id:5772,x:30986,y:33179,ptovrint:False,ptlb:node_5772,ptin:_node_5772,varname:_node_5772,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.7405456,c3:0,c4:1;n:type:ShaderForge.SFN_Clamp01,id:9607,x:31566,y:32751,varname:node_9607,prsc:2|IN-7371-OUT;n:type:ShaderForge.SFN_Multiply,id:7465,x:31755,y:32697,varname:node_7465,prsc:2|A-2662-G,B-9607-OUT;n:type:ShaderForge.SFN_Slider,id:6347,x:31222,y:33230,ptovrint:False,ptlb:shanguangglow,ptin:_shanguangglow,varname:_shanguangglow,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.902543,max:5;n:type:ShaderForge.SFN_Multiply,id:1975,x:30951,y:32730,varname:node_1975,prsc:2|A-3687-T,B-2006-OUT;n:type:ShaderForge.SFN_Cos,id:631,x:31077,y:32597,varname:node_631,prsc:2|IN-1975-OUT;n:type:ShaderForge.SFN_Multiply,id:4571,x:31332,y:32572,varname:node_4571,prsc:2|A-631-OUT,B-5772-RGB;n:type:ShaderForge.SFN_Clamp01,id:3543,x:31543,y:32572,varname:node_3543,prsc:2|IN-4571-OUT;proporder:3411-3036-7888-851-7625-4181-4590-7521-3150-5674-6978-3269-435-297-2662-2006-5772-6347;pass:END;sub:END;*/

Shader "Shader Forge/ICE_mofang" {
    Properties {
        [MaterialToggle] _Hit ("Hit", Float ) = 0
        [MaterialToggle] _Texandice ("Texandice", Float ) = 0
        [MaterialToggle] _Vertex_offset ("Vertex_offset", Float ) = 0
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Tex_ice ("Tex_ice", 2D) = "white" {}
        _Ice_texglow ("Ice_texglow", Range(0, 2)) = 0.7292595
        _Ice_glow ("Ice_glow", Range(0, 2)) = 1
        _Ice_duibidu ("Ice_duibidu", Range(0, 4)) = 2
        _Tex_glow ("Tex_glow", Range(0, 2)) = 1.19646
        _hit_color_glow ("hit_color_glow", Range(0, 2)) = 2
        _tuqi ("tuqi", Range(0, 0.1)) = 0.003143363
        _Dep ("Dep", Range(0, 1)) = 0.1
        _Ice_color ("Ice_color", Color) = (1,1,1,1)
        _hit_color ("hit_color", Color) = (1,0,0,1)
        _mask_rgb ("mask_rgb", 2D) = "white" {}
        _shanguangspeed ("shanguangspeed", Range(0, 10)) = 5.426485
        _node_5772 ("node_5772", Color) = (1,0.7405456,0,1)
        _shanguangglow ("shanguangglow", Range(0, 5)) = 2.902543
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
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
            uniform float _tuqi;
            uniform float4 _Ice_color;
            uniform float _Ice_glow;
            uniform fixed _Vertex_offset;
            uniform float _Dep;
            uniform float _Ice_duibidu;
            uniform sampler2D _mask_rgb; uniform float4 _mask_rgb_ST;
            uniform float _shanguangspeed;
            uniform float4 _node_5772;
            uniform float _shanguangglow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                v.vertex.xyz += lerp( 0.0, (v.normal*_tuqi), _Vertex_offset );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float4 _mask_rgb_var = tex2D(_mask_rgb,TRANSFORM_TEX(i.uv0, _mask_rgb));
                float4 node_3687 = _Time;
                float3 node_8165 = (_Diffuse_var.rgb+(_mask_rgb_var.r*saturate((cos((node_3687.g*_shanguangspeed))*_node_5772.rgb)))+(_mask_rgb_var.g*saturate((sin((node_3687.g*_shanguangspeed))*_node_5772.rgb*_shanguangglow))));
                float2 node_1031 = (_Dep*(0.0 - 0.5)*mul(tangentTransform, viewDirection).xy + i.uv0);
                float4 _Tex_ice_var = tex2D(_Tex_ice,TRANSFORM_TEX(node_1031.rg, _Tex_ice));
                float3 finalColor = lerp( lerp( (node_8165*_Tex_glow), (pow((_Tex_ice_var.rgb*_Ice_color.rgb*_Ice_glow),_Ice_duibidu)+(node_8165*_Ice_texglow)), _Texandice ), (_Diffuse_var.rgb*_hit_color_glow*_hit_color.rgb), _Hit );
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
            Cull Back
            
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
            uniform float _tuqi;
            uniform fixed _Vertex_offset;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float3 normalDir : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                v.vertex.xyz += lerp( 0.0, (v.normal*_tuqi), _Vertex_offset );
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

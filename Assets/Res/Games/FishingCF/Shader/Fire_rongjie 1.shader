// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:34794,y:32655,varname:node_9361,prsc:2|emission-4587-OUT,clip-2357-OUT;n:type:ShaderForge.SFN_Tex2d,id:2703,x:32775,y:32782,ptovrint:False,ptlb:Minmap,ptin:_Minmap,varname:_Minmap,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a65f3dadf7dd8b641ac80c5613bb2106,ntxv:0,isnm:False|UVIN-3812-UVOUT;n:type:ShaderForge.SFN_Panner,id:3812,x:32509,y:32757,varname:node_3812,prsc:2,spu:0,spv:-2|UVIN-6544-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:6214,x:32912,y:32987,ptovrint:False,ptlb:node_6214,ptin:_node_6214,varname:_node_6214,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f1697bd3dbe7f9b42b090b5670ef5e65,ntxv:0,isnm:False|UVIN-619-UVOUT;n:type:ShaderForge.SFN_Panner,id:619,x:32713,y:33009,varname:node_619,prsc:2,spu:0.1,spv:0.1|UVIN-8791-UVOUT,DIST-2995-R;n:type:ShaderForge.SFN_Tex2d,id:2995,x:32556,y:33258,ptovrint:False,ptlb:node_2995,ptin:_node_2995,varname:_node_2995,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1f890dc0673dbc44aaee935a0a437d41,ntxv:0,isnm:False|UVIN-1806-UVOUT;n:type:ShaderForge.SFN_Panner,id:1806,x:32349,y:33258,varname:node_1806,prsc:2,spu:0,spv:0.5|UVIN-6544-UVOUT;n:type:ShaderForge.SFN_Panner,id:8791,x:32498,y:33039,varname:node_8791,prsc:2,spu:0,spv:-1|UVIN-6544-UVOUT;n:type:ShaderForge.SFN_RemapRange,id:3405,x:33383,y:33021,varname:node_3405,prsc:2,frmn:0,frmx:1,tomn:0.47,tomx:1|IN-6214-R;n:type:ShaderForge.SFN_TexCoord,id:8158,x:32850,y:33224,varname:node_8158,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2357,x:33811,y:33065,varname:node_2357,prsc:2|A-3405-OUT,B-2829-OUT,C-515-OUT;n:type:ShaderForge.SFN_OneMinus,id:4577,x:33064,y:33263,varname:node_4577,prsc:2|IN-8158-V;n:type:ShaderForge.SFN_Multiply,id:1435,x:34047,y:32737,varname:node_1435,prsc:2|A-2480-OUT,B-1970-RGB,C-2703-R;n:type:ShaderForge.SFN_Color,id:1970,x:32937,y:32635,ptovrint:False,ptlb:node_1970,ptin:_node_1970,varname:_node_1970,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.5423228,c3:0,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:2480,x:33603,y:32853,ptovrint:False,ptlb:node_2480,ptin:_node_2480,varname:_node_2480,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Tex2d,id:2475,x:33234,y:33411,ptovrint:False,ptlb:node_2475,ptin:_node_2475,varname:_node_2475,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:79aad105948597f42bae5d27d5eef860,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Vector1,id:6624,x:33411,y:33575,varname:node_6624,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Power,id:515,x:33539,y:33398,varname:node_515,prsc:2|VAL-2475-R,EXP-6624-OUT;n:type:ShaderForge.SFN_Power,id:2829,x:33484,y:33178,varname:node_2829,prsc:2|VAL-4577-OUT,EXP-95-OUT;n:type:ShaderForge.SFN_ValueProperty,id:95,x:33234,y:33297,ptovrint:False,ptlb:node_95,ptin:_node_95,varname:_node_95,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:572,x:34317,y:33293,ptovrint:False,ptlb:node_572,ptin:_node_572,varname:_node_572,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:68a52f82b29909a47a0aab77322f8de5,ntxv:0,isnm:False|UVIN-3258-UVOUT;n:type:ShaderForge.SFN_Panner,id:3258,x:34125,y:33323,varname:node_3258,prsc:2,spu:1,spv:1|UVIN-4703-UVOUT,DIST-2357-OUT;n:type:ShaderForge.SFN_TexCoord,id:4703,x:33885,y:33397,varname:node_4703,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:4587,x:34277,y:32900,varname:node_4587,prsc:2|A-1435-OUT,B-572-RGB;n:type:ShaderForge.SFN_TexCoord,id:6544,x:31970,y:32696,varname:node_6544,prsc:2,uv:0,uaff:False;proporder:2703-6214-2995-1970-2480-2475-95-572;pass:END;sub:END;*/

Shader "Shader Forge/Fire_rongjie" {
    Properties {
        _Minmap ("Minmap", 2D) = "white" {}
        _node_6214 ("node_6214", 2D) = "white" {}
        _node_2995 ("node_2995", 2D) = "white" {}
        _node_1970 ("node_1970", Color) = (1,0.5423228,0,1)
        _node_2480 ("node_2480", Float ) = 2
        _node_2475 ("node_2475", 2D) = "white" {}
        _node_95 ("node_95", Float ) = 1
        _node_572 ("node_572", 2D) = "white" {}
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
            Blend One One
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x 
            #pragma target 3.0
            uniform sampler2D _Minmap; uniform float4 _Minmap_ST;
            uniform sampler2D _node_6214; uniform float4 _node_6214_ST;
            uniform sampler2D _node_2995; uniform float4 _node_2995_ST;
            uniform float4 _node_1970;
            uniform float _node_2480;
            uniform sampler2D _node_2475; uniform float4 _node_2475_ST;
            uniform float _node_95;
            uniform sampler2D _node_572; uniform float4 _node_572_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 node_890 = _Time;
                float2 node_1806 = (i.uv0+node_890.g*float2(0,0.5));
                float4 _node_2995_var = tex2D(_node_2995,TRANSFORM_TEX(node_1806, _node_2995));
                float2 node_619 = ((i.uv0+node_890.g*float2(0,-1))+_node_2995_var.r*float2(0.1,0.1));
                float4 _node_6214_var = tex2D(_node_6214,TRANSFORM_TEX(node_619, _node_6214));
                float4 _node_2475_var = tex2D(_node_2475,TRANSFORM_TEX(i.uv0, _node_2475));
                float node_2357 = ((_node_6214_var.r*0.53+0.47)*pow((1.0 - i.uv0.g),_node_95)*pow(_node_2475_var.r,0.2));
                clip(node_2357 - 0.5);
////// Lighting:
////// Emissive:
                float2 node_3812 = (i.uv0+node_890.g*float2(0,-2));
                float4 _Minmap_var = tex2D(_Minmap,TRANSFORM_TEX(node_3812, _Minmap));
                float2 node_3258 = (i.uv0+node_2357*float2(1,1));
                float4 _node_572_var = tex2D(_node_572,TRANSFORM_TEX(node_3258, _node_572));
                float3 emissive = ((_node_2480*_node_1970.rgb*_Minmap_var.r)+_node_572_var.rgb);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
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
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x 
            #pragma target 3.0
            uniform sampler2D _node_6214; uniform float4 _node_6214_ST;
            uniform sampler2D _node_2995; uniform float4 _node_2995_ST;
            uniform sampler2D _node_2475; uniform float4 _node_2475_ST;
            uniform float _node_95;
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
                float4 node_7048 = _Time;
                float2 node_1806 = (i.uv0+node_7048.g*float2(0,0.5));
                float4 _node_2995_var = tex2D(_node_2995,TRANSFORM_TEX(node_1806, _node_2995));
                float2 node_619 = ((i.uv0+node_7048.g*float2(0,-1))+_node_2995_var.r*float2(0.1,0.1));
                float4 _node_6214_var = tex2D(_node_6214,TRANSFORM_TEX(node_619, _node_6214));
                float4 _node_2475_var = tex2D(_node_2475,TRANSFORM_TEX(i.uv0, _node_2475));
                float node_2357 = ((_node_6214_var.r*0.53+0.47)*pow((1.0 - i.uv0.g),_node_95)*pow(_node_2475_var.r,0.2));
                clip(node_2357 - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

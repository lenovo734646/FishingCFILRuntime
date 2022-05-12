// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:32982,y:32578,varname:node_9361,prsc:2|custl-7910-OUT,alpha-9681-OUT;n:type:ShaderForge.SFN_Panner,id:6924,x:32269,y:32476,varname:node_6924,prsc:2,spu:-0.4,spv:0|UVIN-15-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:15,x:31911,y:32549,varname:node_15,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_TexCoord,id:9734,x:31965,y:32773,varname:node_9734,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:3359,x:32275,y:32786,varname:node_3359,prsc:2|IN-9734-U;n:type:ShaderForge.SFN_Clamp01,id:7784,x:32504,y:32806,varname:node_7784,prsc:2|IN-3359-OUT;n:type:ShaderForge.SFN_Multiply,id:485,x:32484,y:32975,varname:node_485,prsc:2|A-7784-OUT,B-745-OUT;n:type:ShaderForge.SFN_ValueProperty,id:745,x:32389,y:33093,ptovrint:False,ptlb:node_745,ptin:_node_745,varname:_node_745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:8522,x:32449,y:32404,ptovrint:False,ptlb:node_8522,ptin:_node_8522,varname:_node_8522,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:eecfa292bcffd9845a64ad49b530b353,ntxv:0,isnm:False|UVIN-6924-UVOUT;n:type:ShaderForge.SFN_Multiply,id:9681,x:32797,y:32947,varname:node_9681,prsc:2|A-8522-A,B-485-OUT;n:type:ShaderForge.SFN_Multiply,id:7910,x:32736,y:32387,varname:node_7910,prsc:2|A-8522-RGB,B-6728-RGB;n:type:ShaderForge.SFN_Color,id:6728,x:32639,y:32558,ptovrint:False,ptlb:node_6728,ptin:_node_6728,varname:_node_6728,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;proporder:745-8522-6728;pass:END;sub:END;*/

Shader "Shader Forge/Eff_shader" {
    Properties {
        _node_745 ("node_745", Float ) = 1
        _node_8522 ("node_8522", 2D) = "white" {}
        _node_6728 ("node_6728", Color) = (0.5,0.5,0.5,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _node_745;
            uniform sampler2D _node_8522; uniform float4 _node_8522_ST;
            uniform float4 _node_6728;
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
////// Lighting:
                float4 node_619 = _Time;
                float2 node_6924 = (i.uv0+node_619.g*float2(-0.4,0));
                float4 _node_8522_var = tex2D(_node_8522,TRANSFORM_TEX(node_6924, _node_8522));
                float3 finalColor = (_node_8522_var.rgb*_node_6728.rgb);
                fixed4 finalRGBA = fixed4(finalColor,(_node_8522_var.a*(saturate((1.0 - i.uv0.r))*_node_745)));
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
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33424,y:32460,varname:node_9361,prsc:2|custl-449-OUT,alpha-485-OUT;n:type:ShaderForge.SFN_Tex2d,id:1759,x:32178,y:32526,ptovrint:False,ptlb:node_1759,ptin:_node_1759,varname:_node_1759,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2418363927a481145bb4141da3fa2fa8,ntxv:0,isnm:False|UVIN-6924-UVOUT;n:type:ShaderForge.SFN_Panner,id:6924,x:31924,y:32515,varname:node_6924,prsc:2,spu:-0.45,spv:0|UVIN-15-UVOUT,DIST-8777-R;n:type:ShaderForge.SFN_TexCoord,id:15,x:31680,y:32686,varname:node_15,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_TexCoord,id:9734,x:32036,y:32945,varname:node_9734,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_OneMinus,id:3359,x:32275,y:32823,varname:node_3359,prsc:2|IN-9734-U;n:type:ShaderForge.SFN_Tex2d,id:8777,x:31685,y:32362,ptovrint:False,ptlb:node_8777,ptin:_node_8777,varname:_node_8777,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:371082bf8edadd349ba8d04c96db08af,ntxv:0,isnm:False|UVIN-5874-UVOUT;n:type:ShaderForge.SFN_Panner,id:5874,x:31346,y:32382,varname:node_5874,prsc:2,spu:-0.5,spv:0|UVIN-8038-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8038,x:31070,y:32530,varname:node_8038,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Clamp01,id:7784,x:32562,y:32819,varname:node_7784,prsc:2|IN-3359-OUT;n:type:ShaderForge.SFN_Multiply,id:485,x:32888,y:32827,varname:node_485,prsc:2|A-7784-OUT,B-745-OUT,C-925-OUT;n:type:ShaderForge.SFN_ValueProperty,id:745,x:33098,y:33088,ptovrint:False,ptlb:node_745,ptin:_node_745,varname:_node_745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:1945,x:32577,y:32522,varname:node_1945,prsc:2|A-1759-RGB,B-2547-RGB;n:type:ShaderForge.SFN_Color,id:2547,x:32373,y:32598,ptovrint:False,ptlb:node_2547,ptin:_node_2547,varname:_node_2547,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:555,x:32521,y:32180,ptovrint:False,ptlb:node_555,ptin:_node_555,varname:_node_555,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2418363927a481145bb4141da3fa2fa8,ntxv:0,isnm:False|UVIN-3057-UVOUT;n:type:ShaderForge.SFN_Panner,id:3057,x:32343,y:32180,varname:node_3057,prsc:2,spu:-0.4,spv:0|UVIN-4397-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:4397,x:32131,y:32180,varname:node_4397,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:476,x:32873,y:32324,varname:node_476,prsc:2|A-555-RGB,B-1945-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3597,x:32766,y:32612,ptovrint:False,ptlb:node_3597,ptin:_node_3597,varname:_node_3597,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Add,id:7770,x:32275,y:33011,varname:node_7770,prsc:2|A-9734-U,B-9467-OUT;n:type:ShaderForge.SFN_Vector1,id:9467,x:32017,y:33132,varname:node_9467,prsc:2,v1:0;n:type:ShaderForge.SFN_Clamp01,id:925,x:32650,y:33014,varname:node_925,prsc:2|IN-5519-OUT;n:type:ShaderForge.SFN_Multiply,id:5519,x:32431,y:33092,varname:node_5519,prsc:2|A-7770-OUT,B-6115-OUT;n:type:ShaderForge.SFN_Power,id:6115,x:32220,y:33213,varname:node_6115,prsc:2|VAL-7512-OUT,EXP-7512-OUT;n:type:ShaderForge.SFN_Vector1,id:7512,x:31979,y:33288,varname:node_7512,prsc:2,v1:2.7;n:type:ShaderForge.SFN_Multiply,id:449,x:33030,y:32453,varname:node_449,prsc:2|A-476-OUT,B-3597-OUT;proporder:1759-8777-745-2547-555-3597;pass:END;sub:END;*/

Shader "Shader Forge/hailang" {
    Properties {
        _node_1759 ("node_1759", 2D) = "white" {}
        _node_8777 ("node_8777", 2D) = "white" {}
        _node_745 ("node_745", Float ) = 0.5
        _node_2547 ("node_2547", Color) = (1,1,1,1)
        _node_555 ("node_555", 2D) = "white" {}
        _node_3597 ("node_3597", Float ) = 3
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
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _node_1759; uniform float4 _node_1759_ST;
            uniform sampler2D _node_8777; uniform float4 _node_8777_ST;
            uniform float _node_745;
            uniform float4 _node_2547;
            uniform sampler2D _node_555; uniform float4 _node_555_ST;
            uniform float _node_3597;
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
                float4 node_3337 = _Time;
                float2 node_3057 = (i.uv0+node_3337.g*float2(-0.4,0));
                float4 _node_555_var = tex2D(_node_555,TRANSFORM_TEX(node_3057, _node_555));
                float2 node_5874 = (i.uv0+node_3337.g*float2(-0.5,0));
                float4 _node_8777_var = tex2D(_node_8777,TRANSFORM_TEX(node_5874, _node_8777));
                float2 node_6924 = (i.uv0+_node_8777_var.r*float2(-0.45,0));
                float4 _node_1759_var = tex2D(_node_1759,TRANSFORM_TEX(node_6924, _node_1759));
                float3 finalColor = ((_node_555_var.rgb*(_node_1759_var.rgb*_node_2547.rgb))*_node_3597);
                float node_7512 = 2.7;
                fixed4 finalRGBA = fixed4(finalColor,(saturate((1.0 - i.uv0.r))*_node_745*saturate(((i.uv0.r+0.0)*pow(node_7512,node_7512)))));
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

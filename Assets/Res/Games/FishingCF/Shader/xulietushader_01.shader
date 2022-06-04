// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33228,y:32692,varname:node_9361,prsc:2|custl-8044-OUT;n:type:ShaderForge.SFN_Tex2d,id:3537,x:32669,y:32742,ptovrint:False,ptlb:node_3537,ptin:_node_3537,varname:_node_3537,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3b0e54abf3a7c1b41befb2a8c579989f,ntxv:0,isnm:False|UVIN-4612-UVOUT;n:type:ShaderForge.SFN_UVTile,id:4612,x:32488,y:32935,varname:node_4612,prsc:2|UVIN-5446-OUT,WDT-2258-X,HGT-1051-OUT,TILE-9719-OUT;n:type:ShaderForge.SFN_ComponentMask,id:5211,x:31957,y:32591,varname:node_5211,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-3262-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:4211,x:31422,y:32525,varname:node_4211,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:1079,x:31384,y:32756,ptovrint:False,ptlb:rotator,ptin:_rotator,varname:_rotator,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Trunc,id:9719,x:32296,y:33176,varname:node_9719,prsc:2|IN-8520-OUT;n:type:ShaderForge.SFN_Rotator,id:3262,x:31784,y:32550,varname:node_3262,prsc:2|UVIN-4211-UVOUT,ANG-1079-OUT;n:type:ShaderForge.SFN_Vector4Property,id:2258,x:31990,y:32932,ptovrint:False,ptlb:UVtile,ptin:_UVtile,varname:_UVtile,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2,v2:2,v3:0,v4:0;n:type:ShaderForge.SFN_Append,id:5446,x:32316,y:32639,varname:node_5446,prsc:2|A-5211-R,B-6549-OUT;n:type:ShaderForge.SFN_OneMinus,id:6549,x:32105,y:32681,varname:node_6549,prsc:2|IN-5211-G;n:type:ShaderForge.SFN_Negate,id:1051,x:32228,y:33020,varname:node_1051,prsc:2|IN-2258-Y;n:type:ShaderForge.SFN_Time,id:5249,x:31792,y:33300,varname:node_5249,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8520,x:32096,y:33320,varname:node_8520,prsc:2|A-5249-T,B-3025-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3025,x:31951,y:33545,ptovrint:False,ptlb:UVspeed,ptin:_UVspeed,varname:_UVspeed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:8044,x:32893,y:32940,varname:node_8044,prsc:2|A-3537-RGB,B-3537-A;proporder:3537-1079-2258-3025;pass:END;sub:END;*/

Shader "Shader Forge/xulietushader_01" {
    Properties {
        _node_3537 ("node_3537", 2D) = "white" {}
        _rotator ("rotator", Float ) = 0
        _UVtile ("UVtile", Vector) = (2,2,0,0)
        _UVspeed ("UVspeed", Float ) = 10
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
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone 
            #pragma target 3.0
            uniform sampler2D _node_3537; uniform float4 _node_3537_ST;
            uniform float _rotator;
            uniform float4 _UVtile;
            uniform float _UVspeed;
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
                float4 node_5249 = _Time;
                float node_9719 = trunc((node_5249.g*_UVspeed));
                float2 node_4612_tc_rcp = float2(1.0,1.0)/float2( _UVtile.r, (-1*_UVtile.g) );
                float node_4612_ty = floor(node_9719 * node_4612_tc_rcp.x);
                float node_4612_tx = node_9719 - _UVtile.r * node_4612_ty;
                float node_3262_ang = _rotator;
                float node_3262_spd = 1.0;
                float node_3262_cos = cos(node_3262_spd*node_3262_ang);
                float node_3262_sin = sin(node_3262_spd*node_3262_ang);
                float2 node_3262_piv = float2(0.5,0.5);
                float2 node_3262 = (mul(i.uv0-node_3262_piv,float2x2( node_3262_cos, -node_3262_sin, node_3262_sin, node_3262_cos))+node_3262_piv);
                float2 node_5211 = node_3262.rg;
                float2 node_4612 = (float2(node_5211.r,(1.0 - node_5211.g)) + float2(node_4612_tx, node_4612_ty)) * node_4612_tc_rcp;
                float4 _node_3537_var = tex2D(_node_3537,TRANSFORM_TEX(node_4612, _node_3537));
                float3 finalColor = (_node_3537_var.rgb*_node_3537_var.a);
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
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone 
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

// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

Shader "DaydreamElements/Demo/Unlit/Transparent NoZTest Color Inside" {
  Properties {
    _Color ("Color", COLOR) = (1, 1, 1, 1)
  }
  SubShader {
    Tags {
      "RenderType"="Transparent"
    }
    LOD 100

    ZWrite Off
    Blend SrcAlpha OneMinusSrcAlpha
    Cull Front
    ZTest Always

    Pass {
      CGPROGRAM
      #pragma vertex vert
      #pragma fragment frag

      #include "UnityCG.cginc"

      struct appdata {
        float4 vertex : POSITION;
        float2 uv : TEXCOORD0;
      };

      struct v2f {
        float2 uv : TEXCOORD0;
        float4 vertex : SV_POSITION;
      };

      sampler2D _MainTex;
      float4 _Color;
      float4 _MainTex_ST;

      v2f vert (appdata v) {
        v2f o;
        float4 vertex4;
        vertex4.xyz = v.vertex;
        vertex4.w = 1.0;
        o.vertex = UnityObjectToClipPos(vertex4);
        o.uv = TRANSFORM_TEX(v.uv, _MainTex);
        return o;
      }

      fixed4 frag (v2f i) : SV_Target {
        // sample the texture
        fixed4 col = _Color;
        return col;
      }
      ENDCG
    }
  }
  FallBack "Unlit/Transparent"
}

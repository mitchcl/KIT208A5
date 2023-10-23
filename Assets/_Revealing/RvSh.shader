Shader  "Custom/RvSh"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _LightDirection("Light Direction", Vector) = (0, 0, 1, 0)
        _Strength("Strength", Range(0, 1)) = 0.5
    }

    SubShader
    {
        Tags { "RenderType" = "Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
#include "UnityCG.cginc"

struct appdata_t
{
    float4 vertex : POSITION;
    float2 uv : TEXCOORD0;
};

struct v2f
{
    float2 uv : TEXCOORD0;
    float4 vertex : SV_POSITION;
};

sampler2D _MainTex;
float4 _LightDirection;
float _Strength;

v2f vert(appdata_t v)
{
    v2f o;
    o.vertex = UnityObjectToClipPos(v.vertex);
    o.uv = v.uv;
    return o;
}

fixed4 frag(v2f i) : SV_Target
{
                // Calculate lighting
    float scale = dot(normalize(i.vertex), _LightDirection);
    float strength = smoothstep(0, _Strength, scale);

                // Sample the texture
    fixed4 col = tex2D(_MainTex, i.uv);

                // Apply revealing effect
    col.a = col.a * strength; // Adjust transparency

    return col;
}
            ENDCG
        }
    }
}
}

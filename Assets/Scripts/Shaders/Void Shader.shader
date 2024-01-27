Shader "Custom/Void Shader"
{
    Properties
    {
        _Level ("Corruption Level", Range(0,1)) = 1
        _Strength ("Strength", Float) = 2
        _DarkColor ("Dark Color", Color) = (0,0,0,1)
        _LightColor ("Light Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _VoidTexture ("Void Texture", Cube) = "white" {}
        _Waves ("Wave Frequency", Float) = 10
        _WaveStrength ("Wave Strength", Float) = 0.1
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _GlossinessVoid ("Void Smoothness", Range(0,1)) = 0.5
        _MetallicVOid ("Void Metallic", Range(0,1)) = 0.0
        
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;
        samplerCUBE _VoidTexture;

        struct Input
        {
            float2 uv_MainTex;
            float3 viewDir;
            float3 worldNormal;
            float3 worldPos;
        };

        float _Waves;
        float _WaveStrength;
        half _Level;
        half _Glossiness;
        half _Metallic;
        half _GlossinessVoid;
        half _MetallicVoid;
        fixed4 _DarkColor;
        fixed4 _LightColor;
        float _Strength;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            float gamma = 2.2;
            float3 objectPos = mul(unity_WorldToObject,float4(IN.worldPos,1)).rgb;
            float angle = atan2(objectPos.z,objectPos.x);
            float wave = (0.5 * cos(angle * _Waves) + 0.5) * _WaveStrength;
            float heightBoundary = 2 * _Level -1 + wave;
            bool corrupted = objectPos.y < heightBoundary;
            // Albedo comes from a texture tinted by color
            float4 sTex = pow(tex2D(_MainTex, IN.uv_MainTex),1/gamma);
            float4 sCube = pow(texCUBE(_VoidTexture,IN.viewDir),1/gamma);
            float t = sCube.r * _Strength;
            float3 voidColor = lerp(_DarkColor,_LightColor,t);
            float3 normalColor = sTex.rgb;
            
            
            o.Albedo = corrupted ? voidColor : normalColor;
            o.Emission = corrupted ? voidColor : 0;
            o.Metallic = corrupted ? _MetallicVoid : _Metallic;
            o.Smoothness = corrupted ? _GlossinessVoid : _Glossiness;
            
            o.Emission = pow(o.Emission,gamma);
            o.Albedo = pow(o.Albedo,gamma);

            
            // Metallic and smoothness come from slider variables
            o.Alpha = 1;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

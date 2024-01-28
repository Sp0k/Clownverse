Shader "Custom/Void Shader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _Level ("Corruption Level", Range(0,1)) = 0.5
        _DarkColor ("Dark Color", Color) = (0,0,0,1)
        _LightColor ("Light Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _CellSize ("Cell Size", Float) = 0.1
        _Octaves ("Octaves", Integer) = 4
        _Seed ("Seed", Vector) = (0,0,0)
        _VoidCellSize ("Void Cell Size", Float) = 0.1
        _VoidOctaves ("Void Octaves", Integer) = 1
        _VoidSeed ("Void Seed", Vector) = (0,0,0)
        _StarCellSize ("Star Cell Size", Float) = 0.1
        _StarOctaves ("Star Octaves", Integer) = 4
        _StarSeed ("Star Seed", Vector) = (0,0,0)
        _StarThreshold ("Star Threshold",Float) = 8
        _StarExposure ("Star Exposure",Float) = 200
        _StarBlend ("Star Blend",Range(0,1)) = 0.5
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _GlossinessVoid ("Void Smoothness", Range(0,1)) = 0.5
        _MetallicVOid ("Void Metallic", Range(0,1)) = 0.0
        
    }
    SubShader
    {
        Tags {  "Queue"="Transparent" "RenderType"="Transparent"}
        LOD 200
         Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
            ZWrite On
            ZTest LEqual
            Offset 0 , 0
            ColorMask RGBA
        
        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows keepalpha

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0
    
        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
            float3 viewDir;
            float3 worldNormal;
            float3 worldPos;
        };

        float4 _Color;
        float _CellSize;
        int _Octaves;
        float3 _Seed;
        float _VoidCellSize;
        int _VoidOctaves;
        float3 _VoidSeed;
        float _StarCellSize;
        int _StarOctaves;
        float3 _StarSeed;
        float _StarThreshold;
        float _StarExposure;
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

        #include "noise.cginc"

        float space(float3 dir)
        {
            dir = normalize(dir);
            float clouds = 0.5*perlinNoise3DOctaves(dir,_VoidCellSize,_VoidSeed,_VoidOctaves)+0.5;
            // from https://www.shadertoy.com/view/NtsBzB
            float starNoise = 0.5*perlinNoise3DOctaves(dir,_StarCellSize,_StarSeed,_StarOctaves)+0.5;
            float stars = pow(clamp(starNoise, 0.0f, 1.0f), _StarThreshold) * _StarExposure;
            return stars + clouds;
        }
        
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            float gamma = 2.2;
            float3 objectPos = mul(unity_WorldToObject,float4(IN.worldPos,1)).rgb;
            float noise = 0.5*perlinNoise3DOctaves(objectPos,_CellSize,_Seed,_Octaves)+0.5;
            bool corrupted = noise*0.99 < _Level;
            // Albedo comes from a texture tinted by color
            float4 sTex = pow(tex2D(_MainTex, IN.uv_MainTex),1/gamma);
            //float t = sCube.b * _Strength;
            float t = space(IN.viewDir);
            float3 voidColor = lerp(_DarkColor,_LightColor,t);
            float3 normalColor = sTex.rgb*_Color;
            
            o.Albedo = corrupted ? voidColor : normalColor;
            o.Emission = corrupted ? voidColor : 0;
            o.Metallic = corrupted ? _MetallicVoid : _Metallic;
            o.Smoothness = corrupted ? _GlossinessVoid : _Glossiness;
            
            o.Emission = pow(o.Emission,gamma);
            o.Albedo = pow(o.Albedo.rgb,gamma);

            
            o.Alpha = _Color.a;
            
        }
        ENDCG
    }
    FallBack "Standard"
}

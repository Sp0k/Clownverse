#define BIG 14962
#define UI0 1597334673U
#define UI1 3812015801U
#define UI2 uint2(UI0, UI1)
#define UI3 uint3(UI0, UI1, 2798796415U)
#define UIF (1.0 / float(0xffffffffU))

float3 hash(float3 x)
{
    x = x * BIG;
    uint3 q = uint3(int3(x)) * UI3;
    q = (q.x ^ q.y ^ q.z)*UI3;
    return float3(q) * UIF;
}

float perlinNoise3D(float3 pos, float cellSize, float3 seed)
{
    float3 scaledPos = pos / cellSize;
    float3 cornerPositions[8];
    float dotProducts[8];
    float3 floors = floor(scaledPos);
    float3 ceils = ceil(scaledPos);
    cornerPositions[0] = floors;
    cornerPositions[1] = float3(ceils.x,floors.yz);
    cornerPositions[2] = float3(floors.x,ceils.y,floors.z);
    cornerPositions[3] = float3(ceils.xy,floors.z);
    cornerPositions[4] = float3(floors.xy,ceils.z);
    cornerPositions[5] = float3(ceils.x,floors.y,ceils.z);
    cornerPositions[6] = float3(floors.x,ceils.yz);
    cornerPositions[7] = ceils;

    for(int i = 0; i < 8; i++)
    {
        cornerPositions[i] *= cellSize;

        float3 cornerVector = 2 * hash(cornerPositions[i] + seed) - 1;
        float3 pointVector = pos - cornerPositions[i];
        dotProducts[i] = dot(cornerVector,pointVector);
    }
    float smoothX = smoothstep(cornerPositions[0].x,cornerPositions[1].x,pos.x);
    float smoothY = smoothstep(cornerPositions[0].y,cornerPositions[2].y,pos.y);
    float smoothZ = smoothstep(cornerPositions[0].z,cornerPositions[4].z,pos.z);
    float interpX[4];
    for(int i = 0; i < 4; i++) {
        interpX[i] = lerp(dotProducts[i*2],dotProducts[i*2+1],smoothX);
    }
    float interpYTop = lerp(interpX[0],interpX[1],smoothY);
    float interpYBottom = lerp(interpX[2],interpX[3],smoothY);
    return clamp(2.*lerp(interpYTop,interpYBottom ,smoothZ)/cellSize,-1,1);
}

float perlinNoise3DOctaves(float3 pos, float cellSize, float3 seed, int octaves) {
    float noiseValue = 0.;
    float currCellSize = cellSize;
    float3 currSeed = seed;
    float octaveSize = 1.; 
    for(int i = 1; i <= octaves; i++) {
        noiseValue += perlinNoise3D(pos,currCellSize*octaveSize,currSeed)*octaveSize;
        octaveSize *= 0.5;
        currSeed = hash(currSeed);
    }
    
    return atan(4*noiseValue)*UNITY_INV_HALF_PI;
}
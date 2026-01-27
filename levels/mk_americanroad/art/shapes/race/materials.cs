singleton Material(race_rally_start_finish)
{
    mapTo = "race_rally_start_finish";
    diffuseMap[0] = "race_rally_start_finish_d.dds";
    normalMap[0] = "race_rally_start_finish_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "0.992157 0.992157 0.992157 1";
    specularStrength[0] = "0.588235";
    materialTag0 = "beamng";
    materialTag1 = "Race";
    materialTag1 = "rally";
};

singleton Material(race_checkered)
{
    mapTo = "race_checkered";
    diffuseMap[0] = "race_checkered_d.dds";
    normalMap[0] = "race_checkered_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "0.992157 0.992157 0.992157 1";
    specularStrength[0] = "0.588235";
    materialTag0 = "beamng";
    materialTag1 = "Race";
    materialTag1 = "rally";
};

singleton Material(race_rally_finish_checkpoints)
{
    mapTo = "race_rally_finish_checkpoints";
    diffuseMap[0] = "race_rally_finish_checkpoints_d.dds";
    normalMap[0] = "race_rally_finish_checkpoints_n.dds";
    specularPower[0] = "39";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "0.992157 0.992157 0.992157 1";
    specularStrength[0] = "0.588235";
    materialTag0 = "beamng";
    materialTag1 = "rally";
    materialTag1 = "rally";
    doubleSided = "1";
};

singleton Material(checkpoint_sign)
{
    mapTo = "checkpoint_sign";
    diffuseMap[0] = "checkpoint_sign.dds";
    specularMap[0] = "levels/mk_americanroad/art/shapes/buildings/Concrete-01_s.dds";
    specularPower[0] = "15";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng";
    materialTag1 = "Race";
    materialTag1 = "rally";
};


singleton Material(sign_arrows)
{
    mapTo = "sign_arrows";
    diffuseColor[0] = "0.996078 0.996078 0.996078 1";
    specular[0] = "0.5 0.5 0.5 1";
    specularPower[0] = "50";
    translucentBlendOp = "None";
    diffuseMap[0] = "arrows_sign_d.dds";
    specularMap[0] = "arrows_sign_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "Race";
    materialTag1 = "rally";
};

singleton Material(race_wood)
{
    mapTo = "race_wood";
    diffuseMap[0] = "wood_d.dds";
    doubleSided = "0";
    translucentBlendOp = "None";
    specularMap[0] = "wood_s.dds";
    normalMap[0] = "wood_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng";
    materialTag1 = "Race";
    materialTag1 = "rally";
};

singleton Material(spraypaint_mark)
{
    mapTo = "spraypaint_mark";
    diffuseMap[0] = "spraypaint_mark_d.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

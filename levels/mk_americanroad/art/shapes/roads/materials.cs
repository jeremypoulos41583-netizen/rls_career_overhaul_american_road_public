
singleton Material(road_asphalt)
{
    mapTo = "road_asphalt";
    vertColor[0] = "1";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road_asphalt_2lane_d.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/road_asphalt_2lane_s.dds";
    normalMap[0] = "levels/mk_americanroad/art/road/road_asphalt_2lane_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    //detailMap[1] = "levels/mk_americanroad/art/shapes/roads/street_concrete1_detail_d.dds";
    detailScale[1] = "8 2";
};

singleton Material(road_snow)
{
    mapTo = "road_snow";
    groundType = "Snow";
    vertColor[0] = "1";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/roads/snow_d.dds";
    specularMap[0] = "levels/mk_americanroad/art/shapes/roads/snow_s.dds";
    reflectivityMap[0] = "levels/mk_americanroad/art/shapes/roads/snow_r.dds";
    normalMap[0] = "levels/mk_americanroad/art/shapes/roads/snow_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
    //detailMap[1] = "levels/mk_americanroad/art/shapes/roads/street_concrete1_detail_d.dds";
    detailScale[1] = "8 2";
};

singleton Material(guardrail)
{
    mapTo = "guardrail";
    vertColor[0] = "1";
    reflectivityMap[0] = "levels/mk_americanroad/art/shapes/roads/guardrail_r.dds";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/roads/guardrail_d.dds";
    specularMap[0] = "levels/mk_americanroad/art/shapes/roads/guardrail_s.dds";
    normalMap[0] = "levels/mk_americanroad/art/shapes/roads/guardrail_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "64";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
    detailScale[0] = "4 0.5";
};

singleton Material(invisible)
{
    mapTo = "invisible";
    groundType = "SLIPPERY";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "0 0 0 0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentBlendOp = "clipAlpha";
    alphaTest = "1";
    alphaRef = "255";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   colorMap[0] = "vehicles/common/null2.dds";
};

singleton Material(rumble)
{
    mapTo = "rumble";
    vertColor[0] = "1";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/roads/rumble_d.dds";
    specularMap[0] = "levels/mk_americanroad/art/shapes/roads/rumble_s.dds";
    normalMap[0] = "levels/mk_americanroad/art/shapes/roads/rumble_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    //detailMap[1] = "levels/mk_americanroad/art/shapes/roads/street_concrete1_detail_d.dds";
    detailScale[1] = "8 2";
};





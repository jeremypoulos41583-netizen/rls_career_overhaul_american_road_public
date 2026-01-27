

singleton Material(zebra_crossing)
{
    mapTo = "unmapped_mat";
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
   annotation = "ZEBRA_CROSSING";
   colorMap[0] = "levels/mk_americanroad/art/road/zebra_crossing_d.dds";
};

singleton Material(BNG_Asphalt_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
	annotation = "STREET";
};

singleton Material(BNG_Road_Dirt)
{
    mapTo = "unmapped_mat";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    normalMap[0] = "levels/mk_americanroad/art/road/road-01_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "1";
    specularMap[0] = "levels/mk_americanroad/art/road/road-01_s.dds";
    useAnisotropic[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.00392157 0.00392157 0.00392157 1";
    scrollSpeed[0] = "4.118";
    specularStrength[0] = "0.294118";
   diffuseColor[0] = "0.996078 0.898039 0.819608 1";
   colorMap[0] = "levels/mk_americanroad/art/road/road-01_d.dds";
   specularStrength0 = "0.294118";
};

singleton Material(Road_Dirt_Coastal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-03_d.dds";
    materialTag0 = "RoadAndPath";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    normalMap[0] = "levels/mk_americanroad/art/road/road-03_n.dds";
    materialTag1 = "beamng";
    specularPower[0] = "1";
    specularStrength[0] = "0.588235";
    specularMap[0] = "levels/mk_americanroad/art/road/road-03_s.dds";
};

singleton Material(Road_Dirt_Coastal_Decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-03_decal.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    materialTag2 = "decal";
};


singleton Material(Road_01_decal)
{
    mapTo = "unmapped_mat";
    materialTag0 = "RoadAndPath";
    translucent = "1";
    materialTag1 = "beamng";
    specular[0] = "0.992157 0.992157 0.992157 1";
    specularPower[0] = "1";
    specularMap[0] = "levels/mk_americanroad/art/road/Road-01_s.dds";
    translucentZWrite = "1";
    castShadows = "0";
    specular[2] = "White";
    specularStrength[0] = "0.294118";
    effectColor[1] = "InvisibleBlack";
   colorMap[0] = "levels/mk_americanroad/art/road/road-01_decals.dds";
   specularStrength0 = "0.294118";
};

singleton Material(Asphalt)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "AsphaltRoad_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "AsphaltRoad_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "AsphaltRoad_s.dds";
    specularMap[0] = "AsphaltRoad_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    specular[3] = "White";
    specularStrength[0] = "0.4";
	annotation = "STREET";
};

singleton Material(BNG_Asphalt_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
	annotation = "STREET";
};

singleton Material(AsphaltRoad_variation_01)
{
    mapTo = "AsphaltRoad_variation_01";
    diffuseMap[0] = "AsphaltRoad_variation_01_d.dds";
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

singleton Material(DirtRoad_variation_01)
{
    mapTo = "DirtRoad_variation_01";
    diffuseMap[0] = "levels/mk_americanroad/art/road/DirtRoad_variation_01_d.dds";
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
    diffuseColor[0] = "0.898039 0.788235 0.662745 0.57";
};

singleton Material(AsphaltRoad_lanes_clear)
{
    mapTo = "unmapped_mat";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "0.784314";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "0.996 0.996 0.996 0.996";
	annotation = "STREET";
   colorMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_d.dds";
   specularStrength0 = "0.588235";
};

singleton Material(AsphaltRoad_lanes)
{
    mapTo = "unmapped_mat";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    cubemap = "cubemap_road_sky_reflection";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_annotation.png";
   annotation = "STREET";
   materialTag2 = "east_coast_usa";
   version = "1";
   specularStrength0 = "0";
   specularStrength1 = "0.980392";
   colorMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
   colorMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_d.dds";
   specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
   specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
};

singleton Material(AsphaltRoad_repairlines)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/eca_road_asphalt_repairlines_d.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/eca_road_asphalt_repairlines_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_halfbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_halfbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_halfbroken_annotation.png";
};

singleton Material(AsphaltRoad_lanes_broken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_broken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_broken_annotation.png";
};

singleton Material(AsphaltRoad_lanes_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_laned_decal_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "AsphaltRoad_laned_decal.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_s.dds";
    specularMap[0] = "asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
	annotation = "STREET";
};

singleton Material(AsphaltRoad_lanes_narrow_unbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_unbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_narrow_unbroken_annotation.png";
};

singleton Material(AsphaltRoad_lanes_narrow_unbroken_mesh)
{
    mapTo = "AsphaltRoad_lanes_narrow_unbroken_mesh";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_unbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "0";
    translucentZWrite = "0";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "1";
    materialTag2 = "mymap";
    annotationMap = "asphaltroad_laned_narrow_unbroken_annotation.png";
};

singleton Material(AsphaltRoad_lanes_narrow_halfbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_halfbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_narrow_halfbroken_annotation.png";
};

singleton Material(AsphaltRoad_lanes_narrow_broken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_broken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_narrow_broken_annotation.png";
};

singleton Material(asphaltroad_laned_nolines)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_nolines_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    annotationMap = "asphaltroad_laned_nolines_annotation.png";
};

singleton Material(AsphaltRoad_track)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_track_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "AsphaltRoad_track_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "AsphaltRoad_track_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "AsphaltRoad_track_s.dds";
    specularMap[0] = "AsphaltRoad_track_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
	annotation = "STREET";
};

singleton Material(AsphaltRoad_damage_edge)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_edge_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularMap[0] = "AsphaltRoad_damage_edge_s.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
    normalMap[0] = "AsphaltRoad_damage_edge_n.dds";
};

singleton Material(road_dirt_top)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0.980392";
    normalMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_n.dds";
    alphaRef = "120";
   diffuseColor[0] = "0.996078 0.862745 0.811765 0.008";
   colorMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_d.dds";
   specularStrength0 = "0.980392";
};

singleton Material(dirt_road_tread_ruts)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "levels/mk_americanroad/art/road/dirt_road_tread_ruts_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0.490196";
    diffuseMap[0] = "levels/mk_americanroad/art/road/dirt_road_tread_ruts_d.dds";
    alphaRef = "134";
    normalMap[0] = "levels/mk_americanroad/art/road/dirt_road_tread_ruts_n.dds";
};

singleton Material(dirt_road_base)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "dirt_road_base_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0.392157";
    diffuseMap[0] = "levels/mk_americanroad/art/road/dirt_road_base_d.dds";
    alphaRef = "134";
    normalMap[0] = "levels/mk_americanroad/art/road/dirt_road_base_n.dds";
};

singleton Material(AsphaltRoad_track_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "0";
    materialTag2 = "RoadAndPath";
	annotation = "STREET";
};

singleton Material(AsphaltRoad_TireTracks_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_TireTracks_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_track_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "1";
    materialTag2 = "RoadAndPath";
};

singleton Material(BNG_Road_02_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-02_decal.dds";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    materialTag0 = "beamng";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    specularMap[0] = "road-02_s.dds";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
	annotation = "STREET";
};


singleton Material(BNG_Road_Dirt_Wide)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-02_d.dds";
    normalMap[0] = "road-02_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    specularMap[0] = "road-02_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
};


singleton Material(AsphaltRoad_damage_sml_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_sml_decal_01.dds";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
};

singleton Material(AsphaltRoad_damage_large_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_large_decal_01_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    materialTag2 = "decal";
    diffuseMap[1] = "AsphaltRoad_damage_large_decal_01.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "AsphaltRoad_damage_large_decal_01_s.dds";
    specularMap[0] = "AsphaltRoad_damage_large_decal_01_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_damage_large_decal_02)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_large_decal_02.dds";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
    specularMap[0] = "AsphaltRoad_damage_large_decal_02_s.dds";
};


singleton Material(road_01_damage_sml_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-01_damage_sml_decal_01_d.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
    specularMap[0] = "road-01_damage_sml_decal_01_s.dds";
};


singleton Material(Road_01_tracks_large_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-01_tracks_large_decal_01.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
};

singleton Material(nat_decals_wetground)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/Industrial/art/decals/nat_wetground_d.dds";
    materialTag0 = "decal";
    materialTag1 = "beamng";
    translucent = "1";
    translucentZWrite = "1";
    specularPower[0] = "46";
    useAnisotropic[0] = "1";
    materialTag2 = "Natural";
    specularStrength[0] = "0.196078";
    pixelSpecular[0] = "1";
};

singleton Material(eca_parking)
{
    mapTo = "eca_parking";
    diffuseMap[0] = "eca_parking_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
    annotationMap = "eca_parking_annotation.png";
};


singleton Material(line_white)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "line_white_d.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    specularStrength[0] = "0";
    annotation = "SOLID_LINE";
};



singleton Material(BNG_Asphalt_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
};

singleton Material(AsphaltRoad_variation_01)
{
    mapTo = "AsphaltRoad_variation_01";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_variation_01_d.dds";
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
   diffuseColor[0] = "0.5 0.4 0.3 0.62";
};

singleton Material(AsphaltRoad_repairlines_01)
{
    mapTo = "AsphaltRoad_variation_01";
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
   diffuseColor[0] = "0.992157 0.992157 0.992157 1";
   colorMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_repairlines_01_d.dds";
   normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_repairlines_01_n.dds";
   specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_repairlines_01_s.dds";
};

singleton Material(DirtRoad_variation_01)
{
    mapTo = "DirtRoad_variation_01";
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
    diffuseColor[0] = "0.898039 0.788235 0.662745 0.587";
   colorMap[0] = "levels/mk_americanroad/art/road/DirtRoad_variation_01_d.dds";
};

singleton Material(AsphaltRoad_lanes_clear)
{
    mapTo = "unmapped_mat";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "0.588235";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "0.996 0.996 0.996 0.996";
   colorMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_d.dds";
   specularStrength0 = "0.588235";
};

singleton Material(asphaltroad_laned_centerline_broken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_centerline_broken_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "0.784314";
    normalMap[0] = "asphaltroad_laned_centerline_n.dds";
    specularMap[0] = "asphaltroad_laned_centerline_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "1 1 1 1";
};

singleton Material(asphaltroad_laned_centerline_broken_white)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_centerline_white_broken_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "0.784314";
    normalMap[0] = "asphaltroad_laned_centerline_n.dds";
    specularMap[0] = "asphaltroad_laned_centerline_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "1 1 1 1";
};

singleton Material(asphaltroad_laned_centerline_unbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_centerline_unbroken_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "0.784314";
    normalMap[0] = "asphaltroad_laned_centerline_n.dds";
    specularMap[0] = "asphaltroad_laned_centerline_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "1 1 1 1";
};

singleton Material(asphaltroad_laned_centerline_halfbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_centerline_halfbroken_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "0.784314";
    normalMap[0] = "asphaltroad_laned_centerline_n.dds";
    specularMap[0] = "asphaltroad_laned_centerline_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "1 1 1 1";
};

singleton Material(BNG_Road_Dirt)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-01_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    normalMap[0] = "levels/mk_americanroad/art/road/road-01_n.dds";
    specularPower[0] = "24";
    pixelSpecular[0] = "1";
    specularMap[0] = "levels/mk_americanroad/art/road/road-01_s.dds";
    useAnisotropic[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.00392157 0.00392157 0.00392157 1";
    scrollSpeed[0] = "4.118";
};

singleton Material(Road_Dirt_Coastal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-03_d.dds";
    materialTag0 = "BeamNG";
    materialTag1 = "RoadAndPath";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    normalMap[0] = "levels/mk_americanroad/art/road/road-03_n.dds";
};

singleton Material(Road_Dirt_Coastal_Decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-03_decal.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    materialTag2 = "decal";
};


singleton Material(Road_01_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-01_decals.dds";
    materialTag0 = "RoadAndPath";
    translucent = "1";
    materialTag1 = "beamng";
    specular[0] = "0.992157 0.992157 0.992157 1";
    specularPower[0] = "1";
    specularMap[0] = "Road-01_s.dds";
    translucentZWrite = "1";
    castShadows = "0";
};

singleton Material(Asphalt)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    specular[3] = "White";
    specularStrength[0] = "0.588235";
   specularStrength[1] = "0";
   diffuseColor[1] = "0.831373 0.827451 0.827451 1";
   materialTag2 = "east_coast_usa";
};

singleton Material(BNG_Asphalt_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
};

singleton Material(AsphaltRoad_lanes)
{
    mapTo = "unmapped_mat";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
   specularStrength[0] = "0";
   specularStrength[1] = "0.980392";
   colorMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
   colorMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_d.dds";
   specularStrength1 = "0.980392";
   specularStrength0 = "0";
};

singleton Material(AsphaltRoad_lanes_mesh)
{
    mapTo = "AsphaltRoad_lanes_mesh";
    doubleSided = "0";
    translucentBlendOp = "None";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucentZWrite = "0";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "1";
   specularStrength[0] = "0";
   specularStrength[1] = "0.980392";
   colorMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
   colorMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_d.dds";
   specularStrength1 = "0.980392";
   specularStrength0 = "0";
   materialTag2 = "Industrial";
};

singleton Material(AsphaltRoad_lanes_narrow_unbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_unbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_narrow_unbroken_mesh)
{
    mapTo = "AsphaltRoad_lanes_narrow_unbroken_mesh";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "0";
    translucentZWrite = "0";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "1";
    materialTag2 = "east_coast_usa";
   normalMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_laned_n.dds";
   specularStrength[0] = "0";
   specularStrength[1] = "0.392157";
};

singleton Material(AsphaltRoad_lanes_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_laned_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_laned_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "1";
};

singleton Material(AsphaltRoad_track)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    specular[0] = "0.996078 0.992157 0.992157 1";
    materialTag2 = "RoadAndPath";
    translucent = "1";
    translucentZWrite = "1";
    diffuseColor[0] = "0.992157 0.992157 0.992157 1";
    minnaertConstant[0] = "0";
};

singleton Material(AsphaltRoad_track_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "1";
    materialTag2 = "RoadAndPath";
};

singleton Material(AsphaltRoad_TireTracks_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_TireTracks_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "1";
    materialTag2 = "RoadAndPath";
};

singleton Material(BNG_Road_02_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-02_decal.dds";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    materialTag0 = "beamng";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    specularMap[0] = "levels/mk_americanroad/art/road/road-02_s.dds";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
};


singleton Material(BNG_Road_Dirt_Wide)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-02_d.dds";
    normalMap[0] = "levels/mk_americanroad/art/road/road-02_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    specularMap[0] = "levels/mk_americanroad/art/road/road-02_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
};


singleton Material(AsphaltRoad_damage_sml_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_sml_decal_01.dds";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
};

singleton Material(AsphaltRoad_damage_large_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_large_decal_01.dds";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
};

singleton Material(AsphaltRoad_damage_large_decal_02)
{
    mapTo = "unmapped_mat";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_large_decal_02_s.dds";
   colorMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_large_decal_02.dds";
   normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_large_decal_02_n.dds";
};


singleton Material(road_01_damage_sml_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-01_damage_sml_decal_01_d.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
    specularMap[0] = "levels/mk_americanroad/art/road/road-01_damage_sml_decal_01_s.dds";
};


singleton Material(Road_01_tracks_large_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-01_tracks_large_decal_01.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
};

singleton Material(mymap_dirt_road)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_dirt_road_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.992157 0.992157 0.992157 1";
    scrollSpeed[0] = "4.118";
    diffuseColor[0] = "0.909804 0.909804 0.909804 1";
    normalMap[0] = "levels/mk_americanroad/art/road/mymap_dirt_road_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/mymap_dirt_road_s.dds";
};

singleton Material(mymap_dirt_trail)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_dirt_trail_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    specularPower[0] = "29";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.992157 0.992157 0.992157 1";
    scrollSpeed[0] = "4.118";
    materialTag2 = "RoadAndPath";
    normalMap[0] = "levels/mk_americanroad/art/road/mymap_dirt_trail_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/mymap_dirt_trail_s.dds";
};



singleton Material(AsphaltRoad_damage_edge)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_edge_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularMap[0] = "AsphaltRoad_damage_edge_s.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
    normalMap[0] = "AsphaltRoad_damage_edge_n.dds";
};

singleton Material(road_dirt_top)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0.980392";
    normalMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_n.dds";
    alphaRef = "120";
   diffuseColor[0] = "0.996078 0.862745 0.811765 0.975";
   colorMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_d.dds";
   specularStrength0 = "0.980392";
};

singleton Material(dirt_road_base)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "levels/mk_americanroad/art/road/dirt_road_base_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0.392157";
    diffuseMap[0] = "levels/mk_americanroad/art/road/dirt_road_base_d.dds";
    alphaRef = "134";
    normalMap[0] = "levels/mk_americanroad/art/road/dirt_road_base_n.dds";
    diffuseColor[0] = "0.86 0.8 0.83 0.975";
};

singleton Material(dirt_road_tread_ruts)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "levels/mk_americanroad/art/road/dirt_road_tread_ruts_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0";
    diffuseMap[0] = "levels/mk_americanroad/art/road/dirt_road_tread_ruts_d.dds";
    alphaRef = "134";
    normalMap[0] = "levels/mk_americanroad/art/road/dirt_road_tread_ruts_n.dds";
    diffuseColor[0] = "0.92 0.82 0.8 0.975";
};

singleton Material(eca_parking)
{
    mapTo = "eca_parking";
    diffuseMap[0] = "eca_parking_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
};


singleton Material(mymap_curb1)
{
   mapTo = "mymap_curb1";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_curb1.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_curb2)
{
   mapTo = "mymap_curb2";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_curb2.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};


singleton Material(BNG_Asphalt_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
};

singleton Material(BNG_Road_Dirt)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-01_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    normalMap[0] = "levels/mk_americanroad/art/road/road-01_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "1";
    specularMap[0] = "levels/mk_americanroad/art/road/road-01_s.dds";
    useAnisotropic[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.00392157 0.00392157 0.00392157 1";
    scrollSpeed[0] = "4.118";
    specularStrength[0] = "0.294118";
};

singleton Material(Road_Dirt_Coastal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-03_d.dds";
    materialTag0 = "RoadAndPath";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    normalMap[0] = "levels/mk_americanroad/art/road/road-03_n.dds";
    materialTag1 = "beamng";
    specularPower[0] = "1";
    specularStrength[0] = "0.588235";
    specularMap[0] = "levels/mk_americanroad/art/road/road-03_s.dds";
};

singleton Material(Road_Dirt_Coastal_Decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-03_decal.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    materialTag2 = "decal";
};


singleton Material(Road_01_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road-01_decals.dds";
    materialTag0 = "RoadAndPath";
    translucent = "1";
    materialTag1 = "beamng";
    specular[0] = "0.992157 0.992157 0.992157 1";
    specularPower[0] = "1";
    specularMap[0] = "levels/mk_americanroad/art/road/Road-01_s.dds";
    translucentZWrite = "1";
    castShadows = "0";
    specular[2] = "White";
    specularStrength[0] = "0.294118";
    effectColor[1] = "InvisibleBlack";
};

singleton Material(Asphalt)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_s.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
};

singleton Material(BNG_Asphalt_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
};

singleton Material(AsphaltRoad_variation_01)
{
    mapTo = "AsphaltRoad_variation_01";
    diffuseMap[0] = "AsphaltRoad_variation_01_d.dds";
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

singleton Material(AsphaltRoad_lanes_clear)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_d.dds";
    materialTag0 = "RoadAndPath";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "1 1 1 1";
    specularStrength[0] = "2.05882";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_clear_s.dds";
    materialTag2 = "beamng";
    diffuseColor[0] = "0.996 0.996 0.996  1";
    specularStrength[1] = "0.784314";
};

singleton Material(AsphaltRoad_lanes)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_repairlines)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/eca_road_asphalt_repairlines_d.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/eca_road_asphalt_repairlines_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_halfbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_halfbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_broken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_broken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_laned_decal_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "AsphaltRoad_laned_decal.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_s.dds";
    specularMap[0] = "asphaltroad_laned_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_narrow_unbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_unbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_narrow_unbroken_mesh)
{
    mapTo = "AsphaltRoad_lanes_narrow_unbroken_mesh";
    diffuseMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_unbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "0";
    translucentZWrite = "0";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "1";
    materialTag2 = "mymap";
};

singleton Material(AsphaltRoad_lanes_narrow_halfbroken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_halfbroken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_lanes_narrow_broken)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_narrow_broken_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(asphaltroad_laned_nolines)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "asphaltroad_laned_narrow_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "asphaltroad_laned_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "asphaltroad_laned_nolines_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "asphaltroad_laned_narrow_s.dds";
    specularMap[0] = "asphaltroad_laned_narrow_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_track)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    subSurfaceRolloff[1] = "0";
    specularStrength[0] = "0";
};

singleton Material(AsphaltRoad_track_joiner)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_joiner_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_joiner_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    specularStrength[0] = "0";
    diffuseColor[0] = "0.99 1 1 2";
};

singleton Material(AsphaltRoad_track_big)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_track_big_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "AsphaltRoad_track_big_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "AsphaltRoad_track_big_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "AsphaltRoad_track_big_s.dds";
    specularMap[0] = "AsphaltRoad_track_big_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_track_big_mesh)
{
    mapTo = "AsphaltRoad_track_big_mesh";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_big_a.dds";
    doubleSided = "0";
    translucentBlendOp = "None";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_big_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_big_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_big_s.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_big_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "0";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "1";
    materialTag2 = "Industrial";
};

singleton Material(AsphaltRoad_track_tirewear)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_tirewear_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_n.dds";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    diffuseMap[1] = "levels/mk_americanroad/art/road/AsphaltRoad_track_tirewear_d.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
    materialTag2 = "mymap";
};

singleton Material(AsphaltRoad_track_skidmarks)
{
    mapTo = "unmapped_mat";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "19";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    normalMap[0] = "levels/mk_americanroad/art/road/white_n.dds";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_skidmarks_d.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/white.dds";
    specularPower[1] = "1";
    specularStrength[0] = "1.37255";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "80";
    castShadows = "0";
    materialTag2 = "mymap";
};


singleton Material(racingline_coast)
{
    mapTo = "unmapped_mat";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "19";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    normalMap[0] = "levels/mk_americanroad/art/road/white_n.dds";
    diffuseMap[0] = "levels/mk_americanroad/art/road/racingline_coast.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/white.dds";
    specularPower[1] = "1";
    specularStrength[0] = "1.37255";
    useAnisotropic[1] = "1";
    emissive[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "80";
    castShadows = "0";
    materialTag2 = "mymap";
};

singleton Material(racingline_brake)
{
    mapTo = "unmapped_mat";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "19";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    normalMap[0] = "levels/mk_americanroad/art/road/white_n.dds";
    diffuseMap[0] = "levels/mk_americanroad/art/road/racingline_brake.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/white.dds";
    specularPower[1] = "1";
    specularStrength[0] = "1.37255";
    useAnisotropic[1] = "1";
    emissive[0] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "80";
    castShadows = "0";
    materialTag2 = "mymap";
};


singleton Material(AsphaltRoad_damage_edge)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_edge_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_edge_s.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
    normalMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_damage_edge_n.dds";
};

singleton Material(road_dirt_top)
{
    mapTo = "unmapped_mat";
    specularMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "8";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "White";
    specularStrength[0] = "0.980392";
    diffuseMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_d.dds";
    normalMap[0] = "levels/mk_americanroad/art/road/road_dirt_top_n.dds";
    alphaRef = "120";
};

singleton Material(green_concrete)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/hr_greenconcrete_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularMap[0] = "levels/mk_americanroad/art/road/hr_greenconcrete_s.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "1.56863";
    normalMap[0] = "levels/mk_americanroad/art/road/hr_greenconcrete_n.dds";
    diffuseColor[0] = "0.819608 0.835294 0.792157 1";
};

singleton Material(hr_track_edging)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/hr_track_edging_d.dds";
    normalMap[0] = "levels/mk_americanroad/art/road/hr_track_edging_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/hr_track_edging_s.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    specularStrength[0] = "0.882353";
};

singleton Material(hr_parking)
{
    mapTo = "hr_parking";
    diffuseMap[0] = "levels/mk_americanroad/art/road/hr_parking_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.490196";
};

singleton Material(hr_pit_edging)
{
    mapTo = "hr_pit_edging";
    diffuseMap[0] = "levels/mk_americanroad/art/road/hr_pit_edging_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.882353";
    normalMap[0] = "levels/mk_americanroad/art/road/hr_pit_edging_n.dds";
    specularMap[0] = "levels/mk_americanroad/art/road/hr_pit_edging_s.dds";
};

singleton Material(hr_checkered_line)
{
    mapTo = "hr_checkered_line";
    diffuseMap[0] = "levels/mk_americanroad/art/road/hr_checkered_line_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "128";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "0.882353";
    alphaRef = "208";
};

singleton Material(hr_grasslines_road_d)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/hr_grasslines_road_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    specular[0] = "0.996078 0.996078 0.996078 1";
    materialTag2 = "RoadAndPath";
    specularStrength[0] = "1.56863";
    diffuseColor[0] = "0.819608 0.835294 0.792157 1";
};

singleton Material(AsphaltRoad_track_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "0";
    materialTag2 = "RoadAndPath";
};

singleton Material(AsphaltRoad_TireTracks_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_TireTracks_decal.dds";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
    specularMap[0] = "AsphaltRoad_track_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    subSurface[0] = "1";
    materialTag2 = "RoadAndPath";
};

singleton Material(BNG_Road_02_decal)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-02_decal.dds";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    materialTag0 = "beamng";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    specularMap[0] = "road-02_s.dds";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
};


singleton Material(BNG_Road_Dirt_Wide)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-02_d.dds";
    normalMap[0] = "road-02_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    specularMap[0] = "road-02_s.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "RoadAndPath";
};


singleton Material(AsphaltRoad_damage_sml_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_sml_decal_01.dds";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
};

singleton Material(AsphaltRoad_damage_large_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_large_decal_01_a.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    specularPower[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "RoadAndPath";
    materialTag1 = "beamng";
    materialTag2 = "decal";
    diffuseMap[1] = "AsphaltRoad_damage_large_decal_01.dds";
    cubemap = "cubemap_road_sky_reflection";
    specularMap[1] = "AsphaltRoad_damage_large_decal_01_s.dds";
    specularMap[0] = "AsphaltRoad_damage_large_decal_01_s.dds";
    specularPower[1] = "1";
    useAnisotropic[1] = "1";
    translucent = "1";
    translucentZWrite = "1";
    alphaTest = "0";
    alphaRef = "255";
    castShadows = "0";
};

singleton Material(AsphaltRoad_damage_large_decal_02)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "AsphaltRoad_damage_large_decal_02.dds";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    useAnisotropic[0] = "1";
    specularMap[0] = "AsphaltRoad_damage_large_decal_02_s.dds";
};


singleton Material(road_01_damage_sml_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-01_damage_sml_decal_01_d.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
    specularMap[0] = "road-01_damage_sml_decal_01_s.dds";
};


singleton Material(Road_01_tracks_large_decal_01)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "road-01_tracks_large_decal_01.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
};


singleton Material(chalk_marking)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/chalk_marking_d.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
};

singleton Material(chalk_marking_orange)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/road/chalk_marking_d.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    translucentZWrite = "1";
    materialTag0 = "beamng";
    materialTag1 = "decal";
    materialTag2 = "RoadAndPath";
    specularPower[0] = "14";
    diffuseColor[0] = "1 0.419608 0 0.876";
};



singleton Material(mymap_road1)
{
   mapTo = "mymap_road1";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_road1_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_road2)
{
   mapTo = "mymap_road2";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_road2_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_road3)
{
   mapTo = "mymap_road3";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_road3_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_xmarking)
{
   mapTo = "mymap_xmarking";
   diffuseMap[0] = "levels/mk_americanroad/art/road/x_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_07)
{
   mapTo = "mymap_xmarking";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_07_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_03)
{
   mapTo = "mymap_03";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_03_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_landingline)
{
   mapTo = "mymap_xmarking";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_landinglines_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_line1)
{
   mapTo = "mymap_line1";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_line1_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_line1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_line2)
{
   mapTo = "mymap_line2";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_line2_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_line1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_line3)
{
   mapTo = "mymap_line3";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_line3_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_line1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_line4)
{
   mapTo = "mymap_line4";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_line4_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_line1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_line5)
{
   mapTo = "mymap_line5";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_line5_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_line1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_line6)
{
   mapTo = "mymap_line6";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   pixelSpecular[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
   version = "1";
   specularStrength0 = "0.294118";
   colorMap[0] = "levels/mk_americanroad/art/road/mymap_line6_d";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_line1_s";
   useAnisotropic[0] = "1";
};

singleton Material(mymap_concrete1)
{
   mapTo = "mymap_concrete1";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_concrete1_d";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_checkered_line)
{
   mapTo = "mymap_checkered_line";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_checkered_line_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_checkered_line_s.dds";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};


singleton Material(curb_stripes)
{
   mapTo = "curb_stripes";
   diffuseMap[0] = "levels/mk_americanroad/art/road/curb_stripes_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
};


singleton Material(tirewall)
{
   mapTo = "tirewall";
   diffuseColor[0] = "0.996078 0.996078 0.996078 1";
   translucentBlendOp = "None";
   diffuseMap[0] = "levels/mk_americanroad/art/road/tirewall_d.dds";
   specularMap[0] = "levels/mk_americanroad/art/road/tirewall_s.dds";
   normalMap[0] = "levels/mk_americanroad/art/road/tirewall_n.dds";
};


singleton Material(mymap_track_skidmarks)
{
   mapTo = "mymap_track_skidmarks";
   doubleSided = "0";
   translucentBlendOp = "LerpAlpha";
   specularPower[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   normalMap[0] = "levels/mk_americanroad/art/road/white_n.dds";
   diffuseMap[0] = "levels/mk_americanroad/art/road/AsphaltRoad_track_skidmarks_d.dds";
   specularMap[0] = "levels/mk_americanroad/art/road/white.dds";
   specularPower[1] = "1";
   specularStrength[0] = "0.784314";
   useAnisotropic[1] = "1";
   translucent = "1";
   translucentZWrite = "1";
   alphaTest = "0";
   alphaRef = "255";
   castShadows = "0";
   materialTag2 = "mymap";
};

singleton Material(mymap_grasslines_road_d)
{
   mapTo = "mymap_grasslines_road_d";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_grasslines_road_d.dds";
   materialTag0 = "beamng";
   materialTag1 = "RoadAndPath";
   specularPower[0] = "1";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   castShadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.996078 0.996078 0.996078 1";
   materialTag2 = "RoadAndPath";
   specularStrength[0] = "1.56863";
   diffuseColor[0] = "0.819608 0.835294 0.792157 1";
};

singleton Material(mymap_curb1)
{
   mapTo = "mymap_curb1";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_curb1.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(mymap_curb2)
{
   mapTo = "mymap_curb2";
   diffuseMap[0] = "levels/mk_americanroad/art/road/mymap_curb2.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(keepclear_1)
{
   mapTo = "keepclear_1";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "0";
   translucentZWrite = "0";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
   colorMap[0] = "levels/mk_americanroad/art/road/keepclear_1.dds";
   doubleSided = "0";
   alphaTest = "1";
   alphaRef = "40";
   specularStrength0 = "0.294118";
};

singleton Material(keepclear_2)
{
   mapTo = "keepclear_2";
   diffuseMap[0] = "levels/mk_americanroad/art/road/keepclear_2.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
   specularMap[0] = "levels/mk_americanroad/art/road/mymap_road1_s";
   useAnisotropic[0] = "1";
   translucent = "1";
   translucentZWrite = "1";
   specular[0] = "0.00392157 0.00392157 0.00392157 1";
   scrollSpeed[0] = "4.118";
   specularStrength[0] = "0.294118";
};

singleton Material(newMaterial4)
{
   mapTo = "unmapped_mat";
   specularPower[0] = "34";
   specularMap[0] = "levels/mk_americanroad/art/road/1024conc_rail_spec.dds";
   useAnisotropic[0] = "1";
   Castshadows = "1";
   translucent = "0";
   translucentZWrite = "0";
   alphaTest = "1";
   materialTag0 = "RoadAndPath";
   showDust = "1";
   diffuseColor[0] = "0.996078491 0.996078491 0.996078491 1";
   beamngDiffuseColorSlot = "2";
   materialTag1 = "vehicle";
   specularStrength[0] = "0.294118";
   colorMap[0] = "levels/mk_americanroad/art/road/ConcRailSide2.dds";
   specularStrength0 = "0.294118";
   parallaxScale[0] = "0.100000001";
   doubleSided = "1";
};

singleton Material(Road_HW_YL_R)
{
   mapTo = "Road_HW_YL_R";
   specularPower[0] = "1";
   useAnisotropic[0] = "1";
   Castshadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   materialTag0 = "RoadAndPath";
   diffuseColor[0] = "0.996078491 0.996078491 0.996078491 1";
   materialTag1 = "newroad";
   colorMap[0] = "levels/mk_americanroad/art/road/LightRoad_YLR.dds";
   doubleSided = "0";
   normalMap[0] = "levels/mk_americanroad/art/road/LightRoad_YL_NRM.dds";
   translucentBlendOp = "LerpAlpha";
   specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
};

singleton Material(Road_HW_YL_L)
{
   mapTo = "Road_HW_YL_L";
   specularPower[0] = "1";
   useAnisotropic[0] = "1";
   Castshadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   materialTag0 = "RoadAndPath";
   diffuseColor[0] = "0.996078491 0.996078491 0.996078491 1";
   materialTag1 = "newroad";
   colorMap[0] = "levels/mk_americanroad/art/road/LightRoad_YLL.dds";
   doubleSided = "0";
   normalMap[0] = "levels/mk_americanroad/art/road/LightRoad_YL_NRM.dds";
   translucentBlendOp = "LerpAlpha";
   specularMap[0] = "levels/mk_americanroad/art/road/asphaltroad_laned_s.dds";
};

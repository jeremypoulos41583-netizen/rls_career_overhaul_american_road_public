
singleton Material(grass_field)
{
    mapTo = "grass_field";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/groundcover/grass_field.dds";
    normalMap[0] = "levels/mk_americanroad/art/shapes/groundcover/normalsfix.dds";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "110";
    materialTag1 = "beamng";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag3 = "Natural";
	annotation = "NATURE";
};

singleton Material(plants_grasses)
{
    mapTo = "unmapped_mat";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "140";
    materialTag1 = "beamng";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag3 = "Natural";
    normalMap[0] = "levels/mk_americanroad/art/shapes/groundcover/plants_grasses_n.dds";
	annotation = "NATURE";
   diffuseColor[0] = "0.811764777 0.811764777 0.811764777 1";
   colorMap[0] = "levels/mk_americanroad/art/shapes/groundcover/plants_grasses.dds";
   materialTag4 = "east_coast_usa";
   specularStrength0 = "0.294118";
   roundType = "WOOD";
};


singleton Material(BNG_Grass_Tall)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "grass_field_long.dds";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "107";
    doubleSided = "1";
    specularPower[0] = "1";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "0";
	annotation = "NATURE";
};

singleton Material(lush_vegetation)
{
    mapTo = "lush_vegetation";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/groundcover/lush_vegetation_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "107";
    doubleSided = "1";
    specularPower[0] = "1";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "0";
    specularMap[0] = "lush_vegetation_s.dds";
    materialTag3 = "Natural";
    subSurface[0] = "0";
    subSurfaceColor[0] = "0.858824 1 0 1";
    subSurfaceRolloff[0] = "0.5";
    normalMap[0] = "lush_vegetation_n.dds";
	annotation = "NATURE";
};

singleton Material(lush_vegetation_bb)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/groundcover/lush_vegetation_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "87";
    doubleSided = "1";
    specularPower[0] = "8";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "0";
    materialTag3 = "Natural";
    subSurface[0] = "0";
    subSurfaceColor[0] = "1 0.2 0.2 1";
    subSurfaceRolloff[0] = "0.2";
    castShadows = "0";
    diffuseColor[0] = "0.968628 0.866667 0.952941 1";
    minnaertConstant[0] = "-1";
	annotation = "NATURE";
};

singleton Material(BNGGrass)
{
    mapTo = "unmapped_mat";
    diffuseColor[0] = "0.92549026 0.92549026 0.92549026 1";
    useAnisotropic[0] = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "70";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag1 = "vegetation";
	annotation = "NATURE";
   colorMap[0] = "levels/mk_americanroad/art/shapes/groundcover/Grass_Green_d.dds";
   normalMap[0] = "levels/mk_americanroad/art/shapes/groundcover/Grass_Green_n.dds";
   specularMap[0] = "levels/mk_americanroad/art/shapes/groundcover/Grass_Green_s.dds";
   specular[0] = "0.992156923 0.992156923 0.992156923 1";
   specularPower[0] = "128";
   translucentBlendOp = "None";
   persistentId = "b2d38e39-359b-4603-b334-a3263a4bcc57";
   materialTag4 = "east_coast_usa";
   materialTag3 = "Natural";
};

singleton Material(BNGGrass_2)
{
    mapTo = "unmapped_mat";
    diffuseColor[0] = "0.996078 0.996078 0.996078 1";
    diffuseMap[0] = "grass_field_2_sml_d.dds";
    useAnisotropic[0] = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "65";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag1 = "vegetation";
	annotation = "NATURE";
};

singleton Material(BNGGrass_3)
{
    mapTo = "unmapped_mat";
    diffuseColor[0] = "0.733333349 0.733333349 0.733333349 1";
    useAnisotropic[0] = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "60";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    normalMap[0] = "game:levels/mk_americanroad/art/shapes/groundcover/Grass03_n.dds";
	annotation = "NATURE";
   colorMap[0] = "game:levels/mk_americanroad/art/shapes/groundcover/Grass03_d.dds";
};

singleton Material(BNGGrass)
{
    mapTo = "unmapped_mat";
    diffuseColor[0] = "0.996078 0.996078 0.996078 1";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/groundcover/grass_zboze_sml.dds";
    useAnisotropic[0] = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "127";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag1 = "vegetation";
	annotation = "NATURE";
};

singleton Material(BNGGrass)
{
    mapTo = "unmapped_mat";
    diffuseColor[0] = "0.996078 0.996078 0.996078 1";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/groundcover/grass_zbozeciemne_sml.dds";
    useAnisotropic[0] = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "127";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag1 = "vegetation";
	annotation = "NATURE";
};

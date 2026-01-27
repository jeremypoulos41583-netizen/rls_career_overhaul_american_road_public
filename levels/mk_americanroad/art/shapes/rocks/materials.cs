
singleton Material(rock_01_a)
{
    mapTo = "rocks_01_a";
    normalMap[0] = "game:levels/mk_americanroad/art/shapes/rocks/rocks_01_a_n";
    specularMap[0] = "game:levels/mk_americanroad/art/shapes/rocks/rocks_01_a_s.dds";
    doubleSided = "1";
    translucentBlendOp = "None";
    materialTag0 = "beamng";
    materialTag1 = "Natural";
	annotation = "ROCK";
   colorMap[0] = "game:levels/mk_americanroad/art/shapes/rocks/rocks_01_a_d";
};

singleton Material(terrain_rock)
{
    mapTo = "terrain_rock";
    diffuseColor[0] = "1 1 1 1";
    diffuseMap[0] = "levels/mk_americanroad/art/terrains/Rock-05-D.dds";
    specularMap[0] = "levels/mk_americanroad/art/terrains/Rock-05-S.dds";
    normalMap[0] = "levels/mk_americanroad/art/terrains/Rock-05-N2.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    materialTag1 = "Natural";
    materialTag0 = "beamng";
    detailScale[0] = "2 2";
    detailNormalMapStrength[0] = "1";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    specularStrength[0] = "0.392157";
	annotation = "NATURE";
};

singleton Material(terrain_rock_dark)
{
    mapTo = "terrain_rock_dark";
    diffuseColor[0] = "0.552941 0.552941 0.552941 1";
    diffuseMap[0] = "levels/mk_americanroad/art/terrains/Rock-05-D.dds";
    specularMap[0] = "levels/mk_americanroad/art/terrains/Rock-05-S.dds";
    normalMap[0] = "levels/mk_americanroad/art/terrains/Rock-05-N2.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    materialTag1 = "Natural";
    materialTag0 = "beamng";
    detailScale[0] = "2 2";
    detailNormalMapStrength[0] = "1";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    useAnisotropic[0] = "1";
    specularStrength[0] = "0.392157";
	annotation = "NATURE";
};

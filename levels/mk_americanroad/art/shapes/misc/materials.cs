singleton Material(garbage)
{
    mapTo = "garbage";
    diffuseMap[0] = "garbage_d.dds";
    normalMap[0] = "garbage_n.dds";
    specularMap[0] = "garbage_s.dds";
    specularPower[0] = "8";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng";
    materialTag1 = "Utah";
    specular[0] = "1 1 1 1";
    diffuseColor[0] = "1 1 1 1";
	annotation = "OBSTACLES";
};

singleton Material(Concrete_Road_Barrier_a)
{
    mapTo = "concrete_road_barrier_a";
    diffuseMap[0] = "concrete_road_barrier_a_d.dds";
    specularMap[0] = "concrete_road_barrier_a_s.dds";
    normalMap[0] = "concrete_road_barrier_a_n.dds";
    specularPower[0] = "1";
    pixelSpecular[0] = "0";
    diffuseColor[0] = "0.992157 0.992157 0.992157 1";
    materialTag0 = "beamng";
    materialTag1 = "Industrial";
	annotation = "OBSTACLES";
};

singleton Material(terrain_grass2)
{
    mapTo = "terrain_grass2";
    diffuseColor[0] = "0.87451 0.854902 0.639216 1";
    diffuseMap[0] = "levels/mk_americanroad/art/terrains/Grass-02-D.dds";
    normalMap[0] = "levels/mk_americanroad/art/terrains/Grass-02-N.dds";
    doubleSided = "1";
    translucentBlendOp = "None";
    materialTag1 = "Natural";
    materialTag0 = "beamng";
	annotation = "NATURE";
};

singleton Material(eca_backdrop)
{
    mapTo = "eca_backdrop";
    diffuseColor[0] = "0.996078 0.843137 0.666667 0.876";
    diffuseMap[0] = "levels/mk_americanroad/art/shapes/misc/eca_backdrop_d.dds";
    doubleSided = "0";
    translucentBlendOp = "LerpAlpha";
    materialTag1 = "Natural";
    materialTag0 = "beamng";
    useAnisotropic[0] = "1";
    alphaTest = "1";
    alphaRef = "120";
    normalMap[0] = "levels/mk_americanroad/art/shapes/misc/eca_backdrop_n.dds";
	annotation = "NATURE";
};

singleton Material(speedbump_01a)
{
    mapTo = "speedbump_01a";
    diffuseMap[0] = "speedbump_01a_d.dds";
    normalMap[0] = "speedbump_01a_n.dds";
    specularMap[0] = "speedbump_01a_s.dds";
    specularPower[0] = "3";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng";
    materialTag1 = "Industrial";
	annotation = "SPEED_BUMP";
};

singleton Material(container_01_b_Material)
{
    mapTo = "Material";
    diffuseColor[0] = "0.64 0.64 0.64 1";
    doubleSided = "1";
    translucentBlendOp = "None";
	annotation = "BUILDINGS";
};

singleton Material(concrete_bridge_01a)
{
    mapTo = "concrete_bridge_01a";
    diffuseMap[0] = "concrete_bridge_01a_d.dds";
    normalMap[0] = "concrete_bridge_01a_n.dds";
    specularMap[0] = "concrete_bridge_01a_s.dds";
    specularPower[0] = "4";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng";
    materialTag1 = "Industrial";
    specular[0] = "0.4 0.4 0.4 1";
    diffuseColor[0] = "0.8 0.8 0.8 1";
	annotation = "BUILDINGS";
};

singleton Material(container_01_a_containers_01_a)
{
    mapTo = "containers_01_a";
    diffuseColor[0] = "0.996078 0.992157 0.992157 1";
    doubleSided = "0";
    translucentBlendOp = "None";
    diffuseMap[0] = "containers_01_a_d.dds";
    normalMap[0] = "containers_01_a_n.dds";
    specularMap[0] = "containers_01_a_s.dds";
    useAnisotropic[0] = "1";
	annotation = "BUILDINGS";
};

singleton Material(parkinglot_01_a_terrain_rockydirt)
{
    mapTo = "terrain_rockydirt";
    diffuseColor[0] = "0.835294 0.807843 0.8 1";
    doubleSided = "1";
    translucentBlendOp = "None";
    diffuseMap[0] = "levels/mk_americanroad/art/terrains/RockyDirt-01-D.dds";
    normalMap[0] = "levels/mk_americanroad/art/terrains/RockyDirt-01-N.dds";
    specularMap[0] = "levels/mk_americanroad/art/terrains/RockyDirt-01-S.dds";
	annotation = "NATURE";
};

singleton Material(a_asphalt_01_a)
{
    mapTo = "asphalt_01_a";
    diffuseColor[0] = "0.803922 0.803922 0.803922 1";
    diffuseMap[0] = "asphalt_01_a_d.dds";
    specularPower[0] = "1";
    specularMap[0] = "asphalt_01_a_s.dds";
    doubleSided = "1";
    translucentBlendOp = "None";
    materialTag1 = "RoadAndPath";
    materialTag0 = "beamng";
	annotation = "STREET";
};

singleton Material(misc_markings_01)
{
    mapTo = "misc_markings_01";
    diffuseColor[0] = "0.996078 0.996078 0.996078 1";
    diffuseMap[0] = "misc_markings.dds";
    specular[0] = "0.5 0.5 0.5 1";
    specularPower[0] = "1";
    pixelSpecular[0] = "1";
    doubleSided = "1";
    castShadows = "0";
    translucentZWrite = "1";
    alphaTest = "1";
    alphaRef = "40";
    materialTag1 = "Industrial";
    materialTag0 = "beamng";
	annotation = "BUILDINGS";
};


singleton Material(concrete_bridge_01a_AsphaltRoad_laned_mesh)
{
    mapTo = "AsphaltRoad_laned_mesh";
    diffuseColor[0] = "0.588235 0.588235 0.588235 1";
    specular[0] = "0.9 0.9 0.9 1";
    specularPower[0] = "10";
    translucentBlendOp = "None";
	annotation = "STREET";
};


singleton Material(race_checkpoint)
{
    mapTo = "race_checkpoint";
    diffuseMap[0] = "race_checkpoint_texture_d.dds";
    doubleSided = "1";
    translucentBlendOp = "LerpAlpha";
    detailScale[0] = "2 2";
    materialTag0 = "beamng";
    useAnisotropic[0] = "1";
    specular[0] = "0.72549 0.72549 0.72549 1";
    specularPower[0] = "24";
    pixelSpecular[0] = "0";
    diffuseColor[0] = "0.996078 0.0784314 0.00784314 1";
    emissive[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaRef = "129";
    alphaTest = "0";
    animFlags[0] = "0x00000009";
    scrollDir[0] = "0 -1";
    scrollSpeed[0] = "1.059";
    parallaxScale[0] = "0.125";
    glow[0] = "1";
    rotSpeed[0] = "-0.59";
    waveType[0] = "Triangle";
    waveFreq[0] = "0.156";
    waveAmp[0] = "1";
};

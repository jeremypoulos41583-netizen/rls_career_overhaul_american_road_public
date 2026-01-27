
singleton Material(untitled_Material_001)
{
   mapTo = "unmapped_mat";
   diffuseColor[0] = "0.639999986 0.639999986 0.639999986 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   translucentBlendOp = "Mul";
};


singleton Material(road_asphalt_2lane)
{
   mapTo = "unmapped_mat";
   colorMap[0] = "levels/mk_americanroad/art/road/road_asphalt_2lane_d.dds";
   specularMap[0] = "levels/mk_americanroad/art/road/road_asphalt_2lane_s.dds";
   specularPower[0] = "1";
   useAnisotropic[0] = "1";
   castShadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   alphaRef = "255";
   materialTag0 = "RoadAndPath";
   specularStrength0 = "0";
   materialTag1 = "beamng";
};


singleton Material(road_slashes_red)
{
   mapTo = "unmapped_mat";
   colorMap[0] = "levels/mk_americanroad/art/road/road_slashes_red.dds";
   specularPower[0] = "14";
   useAnisotropic[0] = "1";
   castShadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   materialTag0 = "beamng";
   materialTag2 = "RoadAndPath";
   materialTag1 = "decal";
};

singleton Material(curb_stripes)
{
   mapTo = "curb_stripes";
   colorMap[0] = "levels/mk_americanroad/art/road/curb_stripes_d.dds";
   materialTag0 = "RoadAndPath";
   materialTag1 = "beamng";
   translucent = "1";
   translucentZWrite = "1";
   alphaTest = "1";
   alphaRef = "176";
};


singleton Material(eca_road_sidewalk_concrete_annotation_sidebars)
{
   mapTo = "Material_001";
   colorMap[0] = "game:levels/mk_americanroad/art/shapes/buildings/eca/eca_road_sidewalk_concrete_d.dds";
   normalMap[0] = "game:levels/mk_americanroad/art/shapes/buildings/eca/eca_road_sidewalk_concrete_n.dds";
   specularMap[0] = "game:levels/mk_americanroad/art/shapes/buildings/eca/eca_road_sidewalk_concrete_s.dds";
   specularPower[0] = "1";
   useAnisotropic[0] = "1";
   translucentBlendOp = "Mul";
   annotation = "SIDEBARS";
   materialTag2 = "mymap";
   materialTag1 = "building";
   materialTag0 = "beamng";
   specularStrength1 = "0.980392";
   specularStrength0 = "0";
   colorMap[1] = "levels/mk_americanroad/art/shapes/buildings/eca/eca_road_sidewalk_concrete_d.dds";
   normalMap[1] = "levels/mk_americanroad/art/shapes/buildings/eca/eca_road_sidewalk_concrete_n.dds";
   specularMap[1] = "levels/mk_americanroad/art/shapes/buildings/eca/eca_road_sidewalk_concrete_s.dds";
   alphaTest = "0";
   diffuseColor[1] = "0.996078491 0.996078491 0.996078491 2";
   translucent = "0";
   translucentZWrite = "0";
};

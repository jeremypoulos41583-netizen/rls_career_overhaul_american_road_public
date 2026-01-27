
singleton Material(stop_sign_GREEN_004)
{
   mapTo = "GREEN_004";
   diffuseColor[0] = "0.0989149 0.64 0.253415 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   emissive[0] = "0";
};

singleton Material(stop_green_mat)
{
   mapTo = "stop_green";
   diffuseColor[0] = "0.152941 0.54902 0.14902 2";
   materialTag0 = "Miscellaneous";
};

singleton Material(stop_sign_mat)
{
   mapTo = "stop_sign_mat";
   colorMap[0] = "./stop_sign.dds";
   materialTag0 = "Miscellaneous";
};


singleton TSShapeConstructor(Tree_oak_sml_aDae)
{
   baseShape = "./tree_oak_sml_a.dae";
};

function Tree_oak_sml_aDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}


singleton TSShapeConstructor(Tree_oak_bush_cDae)
{
   baseShape = "./tree_oak_bush_c.dae";
};

function Tree_oak_bush_cDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}

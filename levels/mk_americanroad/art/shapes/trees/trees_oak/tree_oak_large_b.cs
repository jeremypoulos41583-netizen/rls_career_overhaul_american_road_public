
singleton TSShapeConstructor(Tree_oak_large_bDae)
{
   baseShape = "./tree_oak_large_b.dae";
};

function Tree_oak_large_bDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}

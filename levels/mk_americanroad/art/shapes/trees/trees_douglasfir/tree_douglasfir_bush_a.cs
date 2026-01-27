
singleton TSShapeConstructor(Tree_douglasfir_bush_aDae)
{
   baseShape = "./tree_douglasfir_bush_a.dae";
};

function Tree_douglasfir_bush_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "64", "1", "0");
}

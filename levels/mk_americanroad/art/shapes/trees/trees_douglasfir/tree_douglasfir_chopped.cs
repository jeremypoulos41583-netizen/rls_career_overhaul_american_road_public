
singleton TSShapeConstructor(Tree_douglasfir_choppedDae)
{
   baseShape = "./tree_douglasfir_chopped.dae";
};

function Tree_douglasfir_choppedDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}

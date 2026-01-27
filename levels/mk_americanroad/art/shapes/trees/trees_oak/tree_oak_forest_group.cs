
singleton TSShapeConstructor(Tree_oak_forest_groupDae)
{
   baseShape = "./tree_oak_forest_group.dae";
};

function Tree_oak_forest_groupDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}

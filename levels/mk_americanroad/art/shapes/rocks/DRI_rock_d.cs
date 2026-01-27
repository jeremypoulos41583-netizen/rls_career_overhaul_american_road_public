
singleton TSShapeConstructor(DRI_rock_dDae)
{
   baseShape = "./DRI_rock_d.dae";
};

function DRI_rock_dDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}

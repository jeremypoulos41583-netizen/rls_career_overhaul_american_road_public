
singleton TSShapeConstructor(Fir_dead_branchesDae)
{
   baseShape = "./fir_dead_branches.dae";
};

function Fir_dead_branchesDae::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "128", "0", "0");
}

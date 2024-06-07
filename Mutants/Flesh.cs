public class Flesh : AbstractMutant
{
    private const string _name = "Плоть";
    public Flesh(int damage, int Hp, bool Dead) : base(damage, Hp, _name, Dead)
    {

    }
    public override string GetMutantDescription()
    {
        return string.Empty;
    }
}
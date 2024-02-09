public class Bloodsucker : Mutant
{
    private const string _name = "Тушкан";
    public Bloodsucker(int damage, int Hp, bool Dead) : base(damage, Hp, _name, Dead)
    {
    }
}
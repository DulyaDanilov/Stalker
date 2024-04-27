using System;
using Training;

public class BlindDog : Mutant
{
    private const string _name = "Слепой пёс";
    public BlindDog(int damage, int Hp, bool Dead) : base(damage, Hp, _name, Dead)
    {

    }
    public override void Attack(Stalker target)
    {
        int multiattack = 4;
        int attackDone = multiattack;
       
        while(--attackDone >= 0)
        {
            int damage = _damage / 2;

            Console.WriteLine($"{_name} бросается на {target.Name} и наносит {damage} урона");
            target.RecieveDamage(damage);
        }
    }
}

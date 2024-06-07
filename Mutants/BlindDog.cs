using System;
using Training;

public class BlindDog : AbstractMutant
{
    private const string _name = "Слепой пёс";
    public BlindDog(int damage, int Hp, bool Dead) : base(damage, Hp, _name, Dead)
    {

    }
    public override void Attack(IHitpointOwner hitpointOwner, ICreatureInfoProvider creatureInfo)
    {
        int multiattack = 4;
        int attackDone = multiattack;
       
        while(--attackDone >= 0)
        {
            int damage = _damage / 2;

            Console.WriteLine($"{_name} бросается на {creatureInfo.Name} и наносит {damage} урона");
            hitpointOwner.RecieveDamage(damage);
        }
    }

    public override string GetMutantDescription()
    {
        return "Слепой пес — самый привычный представитель фауны Зоны. Стаи этих псов можно встретить везде, кроме совершенно гибельных мест.";
    }
}

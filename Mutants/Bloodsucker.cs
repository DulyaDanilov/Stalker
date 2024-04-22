using System;
using Training;

public class Bloodsucker : Mutant
{
    private const string _name = "Кровосос";
    private int _attackCount = 3;
    public Bloodsucker(int damage, int Hp, bool Dead) : base(damage, Hp, _name, Dead)
    {

    }
    public override void Attack(Stalker target)
    {
        for (int attacksDone = 0; attacksDone < _attackCount; attacksDone++)
        {
            base.Attack(target);
            Console.WriteLine($"{_name} наносит быстрый удар по {target.Name}!");
        }
        
        //int attacksDone = _attackCount;
        //while (--attacksDone > 0)
        //{
        //    base.Attack(target);
        //    Console.WriteLine($"{_name} наносит быстрый удар по {target.Name}!");
        //    attacksDone++;
        //}
    }
}
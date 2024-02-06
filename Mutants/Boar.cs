using System;
using Training;

public class Boar : Mutant
{
    private const string _name = "Кабан";
    public Boar(int damage) : base(damage, _name)
    {
    }

    public override void Attack(Stalker target)
    {
        base.Attack(target);
        Console.WriteLine("Кабан издёт громкий визг!");
    }
}
using System;
using Training;

public class Boar : Mutant
{
    private const string _name = "Кабан";
    public Boar(int damage,int Hp,bool Dead) : base(damage,Hp,_name,Dead)
    {
    }

    public override void Attack(Stalker target)
    {
        base.Attack(target);
        Console.WriteLine("Кабан издёт громкий визг!");
    }
    public override void ReciveDamage(int damage)
    {
        base.ReciveDamage(damage);
        Console.WriteLine("Кабан в шоке");
    }
}
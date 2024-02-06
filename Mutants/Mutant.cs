using System;
using Training;

public class Mutant
{
    public string Name;
    protected int damage;
    public Mutant(int damage, string name)
    {
        this.damage = damage;
        Name = name;
    }

    public virtual void Attack(Stalker target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} ");
        target.RecieveDamage(damage);
    }
}
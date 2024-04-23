using System;
using Training;

public class Mutant : IHipointOwner
{
    public string Name;
    protected int _damage;
    protected int Hp;
    public bool Dead;
    public Mutant(int damage,int Hp, string name, bool dead)
    {
        this._damage = damage;
        Name = name;
        this.Hp = Hp;
        Dead = dead;
    }

    public Mutant(int damage, string name)
    {
        this._damage = damage;
        Name = name;
    }

    public virtual void Attack(Stalker target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} ");
        target.RecieveDamage(_damage);
    }
    public virtual void ReciveDamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine(Name + " получил " + damage + " урона!");
        Console.WriteLine($"У {Name} теперь {Hp} здоровья");
        if (Hp <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Dead = true;
        Console.WriteLine($"{Name} умер");
    }
    
    
}
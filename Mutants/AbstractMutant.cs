using System;
using Training;

public abstract class AbstractMutant : IHitpointOwner, ICreatureInfoProvider
{
    public string Name => _name;
    private string _name;
    protected int _damage;
    protected int Hp;
    public bool Dead;
    public AbstractMutant(int damage,int Hp, string name, bool dead)
    {
        this._damage = damage;
        _name = name;
        this.Hp = Hp;
        Dead = dead;
    }

    public abstract string GetMutantDescription();

    public virtual void Attack(IHitpointOwner hitpointOwner, ICreatureInfoProvider creatureInfo)
    {
        Console.WriteLine($"{Name} атакует {creatureInfo.Name} ");
        hitpointOwner.RecieveDamage(_damage);
    }
    public virtual void RecieveDamage(int damage)
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
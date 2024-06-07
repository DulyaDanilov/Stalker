using System;
using Training;

public class Boar : AbstractMutant
{
    private const string _name = "Кабан";
    public Boar(int damage,int Hp,bool Dead) : base(damage,Hp,_name,Dead)
    {
    }

    public override void Attack(IHitpointOwner hitpointOwner, ICreatureInfoProvider creatureInfo)
    {
        base.Attack(hitpointOwner, creatureInfo);


        Console.WriteLine("Кабан издёт громкий визг!");
    }

    public override string GetMutantDescription()
    {
        return "ну кабан и кабан";
    }

    public override void RecieveDamage(int damage)
    {
        base.RecieveDamage(damage);
        Console.WriteLine("Кабан в шоке");
    }
}
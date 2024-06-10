using System;
using Training;

public class Tushkan : AbstractMutant
{
    private const string _name = "Тушкан";
    public Tushkan(int damage,int Hp,bool Dead) : base(damage,Hp,_name,Dead)
    {

    }
    public override void Attack(IHitpointOwner hitpointOwner, ICreatureInfoProvider creatureInfo)
    {
        int attacks = Hp / 5;
        for (int _attackDone = 0; _attackDone < attacks; _attackDone++) 
        {
            base.Attack(hitpointOwner, creatureInfo);
        }
    }

    public override string GetMutantDescription()
    {
        return "Тушканы — очень быстрые и мелкие мутанты, обладающие развитым стайным интеллектом.";
    }
}

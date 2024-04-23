using System;
using Training;

public class Tushkan : Mutant
{
    private const string _name = "Тушкан";
    public Tushkan(int damage,int Hp,bool Dead) : base(damage,Hp,_name,Dead)
    {

    }
    public override void Attack(Stalker target)
    {
        int attacks = Hp / 5;
        for (int _attackDone = 0; _attackDone < attacks; _attackDone++) 
        {
            base.Attack(target);
        }
    }
}

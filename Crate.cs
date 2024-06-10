using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Crate : IHitpointOwner, ICreatureInfoProvider
    {
        public string Name => _name;
        private string _name = "Ящик";
        public int Hp;
        public bool Dead;
        public int MaxHp;

        public Crate(int hp, bool dead, int maxhp)
        {
            Hp = hp;
            this.Dead = dead;
            MaxHp = maxhp;
        }
        public void RecieveDamage(int damage)
        {
           Hp -= damage;
            Console.WriteLine(_name + " отлетел и получил " + damage + " урона");
            Console.WriteLine($"У {_name}а тeперь {Hp} здоровья");
            
            if (Hp <= 0)
            {
                Die();
            }
             
        }
        public void Die()
        {
            Dead = true;
            Console.WriteLine($"{_name} сломан");
        }

    }
}

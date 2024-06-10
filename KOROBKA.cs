using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Korobka : IHitpointOwner, ICreatureInfoProvider
    {
        public string Name => _name;
        private string _name = "Для уебка";
        public int Hp;
        public bool dead;
        public int MaxHp;

        public Korobka(string name, int hp, bool dead, int maxhp)
        {
            _name = name;
            Hp = hp;
            this.dead = dead;
            MaxHp = maxhp;
        }
        public void RecieveDamage(int damage)
        {
           Hp -= damage;
            Console.WriteLine(_name + " отлетела и получила " + damage + " урона");
            Console.WriteLine($"У {_name} тeперь {Hp} здоровья");
            
            if (Hp <= 0)
            {
                Die();
            }
             
        }
        public void Die()
        {
            dead = true;
            Console.WriteLine($"{_name} сломана");
        }

    }
}

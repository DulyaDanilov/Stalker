using System;

namespace Training
{
    public class Stalker
    {
        public string Name = "Дуля Данилов";
        public int Hp; // 0 1 2 3 -4 -5 
        public float Speed; //0.2341231241243
        public bool dead; //true или false
        public int MaxHp;
        public int Damage;
        public Stalker Friend;

        public Stalker(string name, int hp, int maxhp, float speed, bool dead, int damage)
        {
            Name = name;
            Hp = hp;
            Speed = speed;
            this.dead = dead;
            MaxHp = maxhp;
            Damage = damage;
        }
        public void Attack(Mutant mutant)
        {
            Console.WriteLine($"{Name} атаковал  {mutant.Name} и нанёс {Damage} урона!");
            mutant.ReciveDamage(Damage);
        }

        public void EatTushonka(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Hp += 5;
            }
            Console.WriteLine($"{Name} съел {count} банок тушенки и пополнил {count*5} здоровья ");
            Console.WriteLine($"У {Name} теперь {Hp} здороыья");
        }
        public void RunFromTushkan() => Console.WriteLine(Name + " убежал от тушкана со скоростью " + Speed);

        public void RecieveDamage(int damage)
        {
            Hp -= damage;

            Console.WriteLine(Name + " получил " + damage + " урона!");
            Console.WriteLine($"У {Name} теперь {Hp} здоровья");

            if (Hp <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            dead = true;
            Console.WriteLine($"{Name} умер!");
        }
        public void Heal(int Heal)
        {
            Hp += Heal;
            if (Hp < MaxHp)
            {
                Hp = MaxHp;
                Console.WriteLine(Name + " пополнил " + Heal + " здоровья ");
                Console.WriteLine($"У {Name} теперь {Hp} здоровья ");
            }
            
        }
        


        public void PlayGuitar() => Console.WriteLine(Name + " Играет на гитаре");
        public void Yell(string phrase) => Console.WriteLine($"{Name} кричит {phrase}");
        public void PlayFootball(float speed) => Console.WriteLine(Name + " уебал по мячу со скоростью " + speed + " км/ч");
    }
}

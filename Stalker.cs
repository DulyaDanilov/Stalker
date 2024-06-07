using System;

namespace Training
{
    public class Stalker : IHitpointOwner, ICreatureInfoProvider
    {
        public string Name => _name;
        private string _name = "Меченый";
        public int Hp; // 0 1 2 3 -4 -5 
        public float Speed; //0.2341231241243
        public bool dead; //true или false
        public int MaxHp;
        public int Damage;
        public Stalker Friend;


        public Stalker(string name, int hp, int maxhp, float speed, bool dead, int damage)
        {
            _name = name;
            Hp = hp;
            Speed = speed;
            this.dead = dead;
            MaxHp = maxhp;
            Damage = damage;
        }
        public void Attack(IHitpointOwner hitpointOwner, ICreatureInfoProvider creatureInfo)
        {
            Console.WriteLine($"{_name} атаковал  {creatureInfo.Name} и нанёс {Damage} урона!");
            hitpointOwner.RecieveDamage(Damage);
        }

        public void EatTushonka(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Hp += 5;
            }
            Console.WriteLine($"{_name} съел {count} банок тушенки и пополнил {count*5} здоровья ");
            Console.WriteLine($"У {_name} теперь {Hp} здороыья");
        }
        public void RunFromTushkan() => Console.WriteLine(_name + " убежал от тушкана со скоростью " + Speed);

        public void RecieveDamage(int damage)
        {
            Hp -= damage;

            Console.WriteLine(_name + " получил " + damage + " урона!");
            Console.WriteLine($"У {_name} теперь {Hp} здоровья");

            if (Hp <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            dead = true;
            Console.WriteLine($"{_name} умер!");
        }
        public void Heal(int Heal)
        {
            Hp += Heal;
            if (Hp < MaxHp)
            {
                Hp = MaxHp;
                Console.WriteLine(_name + " пополнил " + Heal + " здоровья ");
                Console.WriteLine($"У {_name} теперь {Hp} здоровья ");
            }
            
        }
        


        public void PlayGuitar() => Console.WriteLine(_name + " Играет на гитаре");
        public void Yell(string phrase) => Console.WriteLine($"{_name} кричит {phrase}");
        public void PlayFootball(float speed) => Console.WriteLine(_name  + " уебал по мячу " + speed + " км/ч");
    }
}

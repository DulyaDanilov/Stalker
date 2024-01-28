using System;



    namespace Training


    {
    public class Stalker
    {
            public string Name = "Дуля Данилов";
            public int Hp; // 0 1 2 3 -4 -5 
            public float Speed; //0.2341231241243
            public bool dead; //true или false

        public Stalker Friend;

            public Stalker(string name, int hp, float speed, bool dead)
            {
                Name = name;
                Hp = hp;
                Speed = speed;
                this.dead = dead;
            }

        public void EatTushonka(int Eat)
        {
            Hp += Eat;
            Console.WriteLine(Name + " поел тушенки и пополнил " + Eat + " здоровья ");
            Console.WriteLine($"У {Name} теперь {Hp} здороыья");
        }
        public void RunFromTushkan()
        {
            Console.WriteLine(Name + " убежал от тушкана со скоростью " + Speed);
        }

        public void RecieveDamage(int damage)
        {
            Hp -= damage;

            Console.WriteLine(Name + " получил " + damage + " урона!");
            Console.WriteLine($"У {Name} теперь {Hp} здоровья");
        }

        public void PlayGuitar()
        {
            Console.WriteLine(Name + " Играет на гитаре");
        }

    }

}
    
  

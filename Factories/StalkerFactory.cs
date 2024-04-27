using System;
using Training;

namespace ConsoleApp1.Factories
{
    public class StalkerFactory
    {
        private string[] _names =
        {
            "Дуля Данилов",
            "Ляля Афганский",
            "Чушок Уебанский", 
            "Иван Иваныч",
            "Владимир Петрович",
            "Дурик Балванович",
        };

        private Random _random = new Random();
        public Stalker Get()
        {
            Stalker stalker;
            int nameindex = _random.Next(0, _names.Length - 1);
            string name = _names[nameindex];
            int hp = _random.Next(100, 150);
            int damage = _random.Next(3,7);
            float speed = _random.Next(45,100);
            stalker = new Stalker (name, hp, hp, speed, false, damage); 

            return stalker;
        }

        public Stalker[] GetArray(int size)
        {
            
            Stalker[] stalkers = new Stalker[size];
            for (int i = 0; i <= stalkers.Length -1; i++)
            {
                stalkers[i] = Get();
            }
            return stalkers;
        }

    }
}

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
            "Чушок Уебанский", // и т д 
        };

        private Random _random = new Random();
        public Stalker Get()
        {
            Stalker stalker;
            int nameindex = _random.Next(0, _names.Length - 1);
            string name = _names[nameindex];
            int hp = _random.Next(100, 150);
            int damage = 0;
            float speed = 0;
            
            stalker = new Stalker (name, hp, hp, speed, false, damage);
            ///.
            /// какая-то логика генерации, наверное
            ///.
            return stalker;
        }

        public Stalker[] GetArray(int size)
        {
            Stalker[] stalkers = new Stalker[size];

            ///в цикле заполнить массив

            return stalkers;
        }

    }
}

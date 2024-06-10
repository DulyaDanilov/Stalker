using System;


namespace ConsoleApp1.Factories
{
    public class KorobkaFactory
    {
        private string[] _names =
        {
            "коробка 1",
            "коробка 2",
            "коробка 3",
            "коробка 4",
            "коробка 5",
        };
        private Random _random = new Random();
        public Korobka Get()
        {
            Korobka korobka;
            int nameindex = _random.Next(0, _names.Length - 1);
            string name = _names[nameindex];
            int hp = _random.Next(15, 35);
            korobka = new Korobka(name, hp, false, hp);
            return korobka;
        }
        public Korobka[] GetArray(int size)
        {
            Korobka[] korobka = new Korobka[size];
            for(int i = 0; i <= korobka.Length - 1; i++)
            {
                korobka[i] = Get();
            }
            return korobka;
        }
    }
}

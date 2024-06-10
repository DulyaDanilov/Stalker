using System;


namespace ConsoleApp1.Factories
{
    public class CrateFactory
    {
        
        private Random _random = new Random();
        public Crate Get()
        {
            Crate crate;
            int hp = _random.Next(15, 35);
            crate = new Crate(hp, false, hp);
            return crate;
        }
        public Crate[] GetArray(int size)
        {
            Crate[] crate = new Crate[size];
            for(int i = 0; i <= crate.Length - 1; i++)
            {
                crate[i] = Get();
            }
            return crate;
        }
    }
}

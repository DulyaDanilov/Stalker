using System;

namespace ConsoleApp1.Factories
{
    public class TushkanFactory
    {
        private Random _random = new Random();
        public Tushkan Get()
        {
            Tushkan tushkan; //пустая ссылка
            int hp = _random.Next(5, 10);
            int damage = _random.Next(3, 7);
            tushkan = new Tushkan(damage, hp, false);
            return tushkan;
        }
    }
}

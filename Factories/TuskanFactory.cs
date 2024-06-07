using System;

namespace ConsoleApp1.Factories
{
    public class TushkanFactory
    {
        private Random _random = new Random();
        public Tushkan Get()
        {
            Tushkan tushkan; //пустая ссылка
            int hp = _random.Next(10, 20);
            int damage = _random.Next(8, 12);
            tushkan = new Tushkan(damage, hp, false);
            return tushkan;
        }
    }
}

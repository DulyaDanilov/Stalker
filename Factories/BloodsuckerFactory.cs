using System;
namespace ConsoleApp1.Factories
{
    public class BloodsuckerFactory
    {
        private Random _random= new Random();
        public Bloodsucker Get()
        {
            Bloodsucker bloodsucker;
            int hp = _random.Next(1, 10);
            int damage = _random.Next(1, 10);
            bloodsucker = new Bloodsucker(hp, damage, false);
            return bloodsucker;
        }
    }
}

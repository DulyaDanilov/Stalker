using System;
namespace ConsoleApp1.Factories
{
    public class Boarfactory
    {
        private Random _random = new Random();
        public Boar Get()
        {
            Boar boar;
            int hp = _random.Next(6, 10);
            int damage = _random.Next(5, 7);
            boar = new Boar (hp, damage, false);
            return boar;

        }
    }
}

using System;
namespace ConsoleApp1.Factories
{
    public class Boarfactory
    {
        private Random _random = new Random();
        public Boar Get()
        {
            Boar boar;
            int hp = _random.Next(40, 60);
            int damage = _random.Next(30, 35);
            boar = new Boar (hp, damage, false);
            return boar;

        }
    }
}

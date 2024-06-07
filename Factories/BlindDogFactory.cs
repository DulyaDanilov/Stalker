using System;
namespace ConsoleApp1.Factories
{
    public class BlindDogFactory
    {
        private Random _random = new Random();
        public BlindDog Get()
        {
            BlindDog blindDog;
            int hp = _random.Next(25, 50);
            int damage = _random.Next(16, 24);
            blindDog = new BlindDog(damage, hp, false);
            return blindDog;
        }
    }
}

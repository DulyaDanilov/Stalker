﻿using System;

namespace ConsoleApp1.Factories
{
    public class FleshFactory
    {
        private Random _random = new Random();
        public Flesh Get()
        {
            Flesh flesh;
            int hp = _random.Next(5, 8);
            int damage = _random.Next(4, 5);
            flesh = new Flesh(damage, hp, false);
            return flesh;
        }

    }
}

using System;

namespace ConsoleApp1.Auxillary
{
    public class Random_Info
    {
        Random _random = new Random();
        void TestSyntax()
        {
            _random.Next(0, 10);
            _random.NextDouble(); // от 0 до 1 
            //*=100 процентную верятность и т. п.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training;

class Program

{


    static void Main(string[] args)
    {
        //Console.WriteLine("Дуля Данилов");
        Stalker stalker_1 = new Stalker("Дуля Данилов", 100, 4, false);
        stalker_1.EatTushonka(5);
        stalker_1.RunFromTushkan();
        stalker_1.RecieveDamage(5);
        Stalker stalker_2 = new Stalker("Игорь Ипучий", 145, 1, false);
        stalker_2.PlayGuitar();

        
        Console.ReadLine();
    }


}
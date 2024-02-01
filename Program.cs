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

        Stalker stalker_3 = new Stalker("Ляля Афган", 150, 2, false);
        stalker_3.Yell("Свободовцы все петухи!");


        Stalker stalker_4 = new Stalker("Максимка Чушпан", 300, 40, false);
        stalker_4.PlayFootball(40);

        Stalker stalker_5 = new Stalker("Говноед Медведыч", 200, 40, false);
        stalker_5.RIP();        
        Console.ReadLine();
    }
}
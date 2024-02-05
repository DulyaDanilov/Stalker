using System;
using Training;

class Program

{
    static void Main(string[] args)
    {
        //Console.WriteLine("Дуля Данилов");
        Stalker stalker_1 = new Stalker("Дуля Данилов", 100, 4, false);

        if (stalker_1.Name == "Дуля Данилов" && stalker_1.dead != true)
        {
            stalker_1.Yell($"Меня зовут {stalker_1.Name}");
        }

        if(stalker_1.Hp <= 0)
        {
            Console.WriteLine($"{stalker_1.Name} мёртв");
        }




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
        stalker_5.RecieveDamage(500);      
        Console.ReadLine();
    }
}
//классы методы
//типы данных и переменные
//логические операторы
// if, if else, else
// ==, !=, <, >, <=, >=, && (и), || (или), ^(либо), !bool или bool (напр. dead или !dead) 
//if (dead) //if(dead==true)
//if (!dead) //if(dead!=true)
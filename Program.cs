using System;
using Training;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Дуля Данилов");
        Stalker stalker_1 = new Stalker("Дуля Данилов", 100, 300, 4, false);
        Stalker stalker_2 = new Stalker("Игорь Ипучий", 145, 200, 400, false);
        Stalker stalker_3 = new Stalker("Ляля Афган", 150, 200, 150, false);
        Stalker stalker_4 = new Stalker("Максимка Чушпан", 300, 40, 124, false);
        Stalker stalker_5 = new Stalker("Говноед Медведыч", 200, 40, 490, false);

        Tushkan tushkan_1 = new Tushkan(25);
        Boar boar = new Boar(35);

        boar.Attack(stalker_1);
        tushkan_1.Attack(stalker_1);
        stalker_1.EatTushonka(5);
        stalker_1.RunFromTushkan();
        stalker_1.RecieveDamage(5);
        stalker_2.PlayGuitar();
        stalker_3.Yell("Свободовцы все петухи!");
        stalker_4.PlayFootball(40);
        stalker_5.RecieveDamage(500);
        Console.ReadLine();
    }
}
//классы методы

//типы данных и переменные
//private public

//логические операторы
// if, if else, else
// ==, !=, <, >, <=, >=, && (и), || (или), ^(либо), !bool или bool (напр. dead или !dead) 
//if (dead) //if(dead==true)
//if (!dead) //if(dead!=true)

//наследование
//protected - почти private, но дает использовать потомкам
//sealed - не даёт использовать ниже по иерархии
//virtual - для переопределения, используется в связке с override
//конструктор у наследования вызывается по типу public Boar(int damage) : base(damage, _name) где base это прост овызов конвтруктора
//родителя с заданными аргументами

//циклы
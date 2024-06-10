using System;

class Program
{
    static void Main(string[] args)
    {
        Location cordon = new Location("Кордон");
        cordon.StartDay();

        Console.ReadLine();
    }
}



















//классы методы

//типы данных и переменные
//private public

//логические операторы
// if, if else, else
// ==, !=, <, >, <=, >=, && (и), || (или), ^(либо), !bool или bool (напр. Dead или !Dead) 
//if (Dead) //if(Dead==true)
//if (!Dead) //if(Dead!=true)

//наследование
//protected - почти private, но дает использовать потомкам
//sealed - не даёт использовать ниже по иерархии
//virtual - для переопределения, используется в связке с override
//конструктор у наследования вызывается по типу public Boar(int damage) : base(damage, _name) где base это прост овызов конвтруктора
//родителя с заданными аргументами
//используем класс наследник как клаасс-родитель = приведение

//циклы
// for (int pointer = 0; pointer < 10; pointer++)
// foreach
// while (условие)
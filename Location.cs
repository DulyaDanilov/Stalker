using ConsoleApp1.Factories;
using System;
using Training;

public class Location
{
    public string Name;
    
    public Stalker[] Stalkers = new Stalker[5];
    public Mutant[] Mutants = new Mutant[6];
    
    StalkerFactory stalkerFactory = new StalkerFactory();
    public Location(string name)
    {
        Name = name;
        Stalkers = stalkerFactory.GetArray(5);
        Mutants[0] = new Tushkan(10, 10, false);
        Mutants[1] = new BlindDog(10, 10, false);
        Mutants[2] = new Tushkan(10, 10, false);
        Mutants[3] = new Flesh(10, 10, false);
        Mutants[4] = new Bloodsucker(10, 10, false);
        Mutants[5] = new Boar(10, 10, false);

        Console.WriteLine($"Вы на локации {name}");
        Console.WriteLine(" ");

        Console.WriteLine($"На {name}е находятся сталкеры:");
        
        
        foreach (Stalker stalker in Stalkers)
            Console.WriteLine($"{stalker.Name}");

        Console.WriteLine(" ");

        Console.WriteLine($"На {name}е находятся мутанты:");
        
        foreach (Mutant mutant in Mutants)
            Console.WriteLine($"{mutant.Name}");
       
        Console.WriteLine(" ");
    }
    public void StartDay()
    {
        Stalkers[0].Attack(Mutants[0]);
        Stalkers[2].Yell("Вали, вали хуесоса!");
        Stalkers[3].PlayGuitar();
        Stalkers[4].EatTushonka(10);

        Mutants[4].Attack(Stalkers[0]);
        Mutants[0].Attack(Stalkers[0]);
        Mutants[1].Attack(Stalkers[2]);
    }
}

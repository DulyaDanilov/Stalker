using ConsoleApp1.Factories;
using System;
using Training;

public class Location
{
    public string Name;

    private Random _random = new Random();

    public Stalker[] Stalkers = new Stalker[5];
    public Mutant[] Mutants = new Mutant[6];
    
    StalkerFactory stalkerFactory = new StalkerFactory();
    TushkanFactory tushkanFactory = new TushkanFactory();
    BlindDogFactory blindDogFactory = new BlindDogFactory();
    FleshFactory fleshFactory = new FleshFactory();
    Boarfactory boarFactory = new Boarfactory();
    BloodsuckerFactory bloodsuckerFactory = new BloodsuckerFactory();
    public Location(string name)
    {
        Name = name;

        Stalkers = stalkerFactory.GetArray(_random.Next(1, 10));


        Mutants[0] = tushkanFactory.Get();
        Mutants[1] = blindDogFactory.Get();
        Mutants[2] = fleshFactory.Get();
        Mutants[3] = boarFactory.Get();
        Mutants[4] = bloodsuckerFactory.Get();
        

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
        Stalkers[_random.Next(0, Stalkers.Length-1)].Attack(Mutants[0]);
        Stalkers[2].Yell("Вали, вали хуесоса!");
        Stalkers[3].PlayGuitar();
        Stalkers[4].EatTushonka(10);

        Mutants[_random.Next(0, Mutants.Length - 1)].Attack(Stalkers[0]);
        Mutants[0].Attack(Stalkers[0]);
        Mutants[1].Attack(Stalkers[2]);
    }
}

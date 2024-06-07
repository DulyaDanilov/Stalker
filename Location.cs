using ConsoleApp1.Factories;
using System;
using System.Runtime.InteropServices;
using Training;

public class Location
{
    public string Name;

    private Random _random = new Random();

    public Stalker[] Stalkers = new Stalker[5];
    public Mutant[] Mutants = new Mutant[5];
    
    private StalkerFactory stalkerFactory = new StalkerFactory();
    private TushkanFactory tushkanFactory = new TushkanFactory();
    private BlindDogFactory blindDogFactory = new BlindDogFactory();
    private FleshFactory fleshFactory = new FleshFactory();
    private Boarfactory boarFactory = new Boarfactory();
    private BloodsuckerFactory bloodsuckerFactory = new BloodsuckerFactory();
    public Location(string name)
    {
        Name = name;

        Stalkers = stalkerFactory.GetArray(_random.Next(3, 10));
       

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
        Stalkers[_random.Next(0, Stalkers.Length - 1)].Attack(Mutants[_random.Next(0, Mutants.Length - 1)]);
        Stalkers[_random.Next(0, Stalkers.Length - 1)].EatTushonka(2);
        Stalkers[_random.Next(0, Stalkers.Length - 1)].RunFromTushkan();
        Stalkers[_random.Next(0, Stalkers.Length - 1)].PlayGuitar();
        Stalkers[_random.Next(0, Stalkers.Length - 1)].PlayFootball(80);

        Mutants[_random.Next(0, Mutants.Length - 1)].Attack(Stalkers[_random.Next(0, Stalkers.Length - 1)]);
        Mutants[_random.Next(0, Mutants.Length - 1)].Attack(Stalkers[_random.Next(0, Stalkers.Length - 1)]);
    }
}

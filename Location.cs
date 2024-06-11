using ConsoleApp1;
using ConsoleApp1.Factories;
using System;
using Training;

public class Location
{
    public string Name;

    private Random _random = new Random();

    public Stalker[] Stalkers = new Stalker[5];
    public AbstractMutant[] Mutants = new AbstractMutant[5];
    public Crate[] Crates = new Crate[5];
    
    private StalkerFactory _stalkerFactory = new StalkerFactory();
    private TushkanFactory _tushkanFactory = new TushkanFactory();
    private BlindDogFactory _blindDogFactory = new BlindDogFactory();
    private FleshFactory _fleshFactory = new FleshFactory();
    private Boarfactory _boarFactory = new Boarfactory();
    private BloodsuckerFactory _bloodsuckerFactory = new BloodsuckerFactory();
    private CrateFactory _crateFactory = new CrateFactory();


    public Location(string name)
    {
        Name = name;

        Stalkers = _stalkerFactory.GetArray(_random.Next(3, 10));
        Crates = _crateFactory.GetArray(_random.Next(3, 10));

        Mutants[0] = _tushkanFactory.Get();
        Mutants[1] = _blindDogFactory.Get();
        Mutants[2] = _fleshFactory.Get();
        Mutants[3] = _boarFactory.Get();
        Mutants[4] = _bloodsuckerFactory.Get();
        

        Console.WriteLine($"Вы на локации {name}");
        Console.WriteLine(" ");

        Console.WriteLine($"На {name}е находятся сталкеры:");
        
        
        foreach (Stalker stalker in Stalkers)
            Console.WriteLine($"{stalker.Name}");

        Console.WriteLine(" ");

        Console.WriteLine($"На {name}е находятся мутанты:");
        
        foreach (AbstractMutant mutant in Mutants)
            Console.WriteLine($"{mutant.Name}");
       
        Console.WriteLine(" ");

        Console.WriteLine($"На {name}e валяются {Crates.Length} коробок:");
        Console.WriteLine("");
    }
    public void StartDay()
    {
        RandomStalkerAttackRandomMutant();
        GetRandomStalker().EatTushonka(2);
        GetRandomStalker().RunFromTushkan();
        GetRandomStalker().PlayGuitar();
        GetRandomStalker().PlayFootball(80);

        RandomMutantAttackRandomStalker();
        RandomMutantAttackRandomStalker();
        RandomStalkerAttackRandomCrate();



        RandomStalkerAttackRandomStalker();
    }

    private void RandomStalkerAttackRandomStalker()
    {
        Stalker Attacker = GetRandomStalker();
        Stalker Target = GetRandomStalker();
        if (Attacker == Target)
        {
            Console.WriteLine($"{Attacker.Name} не смог найти сталкера для нападения");
            return;
        }
        Attacker.Attack(Target, Target);
    }

    private void RandomStalkerAttackRandomMutant()
    {
        AbstractMutant mutant = GetRandomMutant();
        GetRandomStalker().Attack(mutant, mutant);
    }

    private void RandomMutantAttackRandomStalker()
    {
        Stalker stalker = GetRandomStalker();
        GetRandomMutant().Attack(stalker, stalker);
    }
    private void RandomStalkerAttackRandomCrate()
    {
        Crate korobka = GetRandomKorobka();
        GetRandomStalker().Attack(korobka, korobka);
    }

    private AbstractMutant GetRandomMutant() => Mutants[_random.Next(0, Mutants.Length - 1)];

    private Stalker GetRandomStalker() => Stalkers[_random.Next(0, Stalkers.Length - 1)];

    private Crate GetRandomKorobka() => Crates[_random.Next(0, Crates.Length - 1)];
}

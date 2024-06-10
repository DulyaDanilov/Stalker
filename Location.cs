using ConsoleApp1;
using ConsoleApp1.Factories;
using System;
using System.Text;
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

    private StringBuilder _sb = new StringBuilder();

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


        Console.WriteLine($"Вы на локации {Name}");
        Console.WriteLine();

        Console.WriteLine($"На {Name}е находятся сталкеры:");


        foreach (Stalker stalker in Stalkers)
            Console.WriteLine($"{stalker.Name}");

        Console.WriteLine(" ");

        Console.WriteLine($"На {Name}е находятся мутанты:");

        foreach (AbstractMutant mutant in Mutants)
            Console.WriteLine(mutant.Name);

        Console.WriteLine(" ");
        DisplayCrates();

        // Console.WriteLine("На " + Name + "e валяются" + Crates.Length + " коробок"); //конкатинация строк, которая приводит к фрагментации памяти

        Console.WriteLine("");
        Console.WriteLine($"Вы - {Stalkers[0].Name}, чего бы вы хотели такого сделать?");
        
        Console.WriteLine($"Доступные действия:" +
            $"АТАКОВАТЬ");
        string action = Console.ReadLine();

        HandleAction(action);

    }

    private void HandleAction(string action)
    {
        if (action == "АТАКОВАТЬ")
        {
            //кого??
            //если сталкеров - вывести сталкеров итд

            Console.WriteLine("Кого вы хотите атаковать?");
            for (int i = 0; i < Stalkers.Length; i++)
            {
                Stalker stalker = Stalkers[i];
                Console.WriteLine($"{i}. {stalker.Name}");
            }
            string indexStr = Console.ReadLine(); //можем считать только текст
            int index = Convert.ToInt32(indexStr); //преобразовать в инт

            Stalkers[0].Attack(Stalkers[index], Stalkers[index]);
        }
        else
        {
            Console.WriteLine("Неизвестная команда!");
        }
    }

    private void DisplayCrates()
    {
        _sb.Append("На "); //добавление текста
        _sb.Append(Name);
        _sb.Append("e валяются ");
        _sb.Append(Crates.Length);
        _sb.Append(" коробок.");

        Console.WriteLine(_sb.ToString()); //выводим содержимое Stringbuilder
        _sb.Clear(); //очистка
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
    private Stalker GetRandomStalker() => Stalkers[_random.Next(1, Stalkers.Length - 1)];
    private Crate GetRandomKorobka() => Crates[_random.Next(0, Crates.Length - 1)];
}

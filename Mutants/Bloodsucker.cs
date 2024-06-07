using System;
using Training;

public class Bloodsucker : AbstractMutant
{
    private const string _name = "Кровосос";
    private int _attackCount = 3;
    public Bloodsucker(int damage, int Hp, bool Dead) : base(damage, Hp, _name, Dead)
    {

    }
    public override void Attack(IHitpointOwner hitpointOwner, ICreatureInfoProvider creatureInfo)
    {
        for (int attacksDone = 0; attacksDone < _attackCount; attacksDone++)
        {
            base.Attack(hitpointOwner, creatureInfo);
            Console.WriteLine($"{_name} наносит быстрый удар по {creatureInfo.Name}!");
        }
    }

    public override string GetMutantDescription()
    {
        return "Полулегендарный монстр — матёрые сталкеры описывают его как высокого сутулого гуманоида со множеством щупалец на месте рта. " +
            "По их словам, с помощью щупалец данное существо питается: впиваясь ими в шею живой жертвы, оно парализует свою добычу и высасывает её кровь; " +
            "после такой процедуры от человека остаётся лишь высохшая, напоминающая мумию оболочка. Наиболее удивительное в кровососе — его способность становиться невидимым. " +
            "Судя по всему, именно эти создания ответственны за смерть большого количества сталкеров. Мало кто из очевидцев остался в живых — и, судя по рассказам этих счастливчиков, " +
            "для обитания кровососы предпочитают сырые места вроде болот и подземелий.";
    }
}
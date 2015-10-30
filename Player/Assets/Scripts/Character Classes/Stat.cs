public class Stat : BaseStat
{
    public Stat()
    {
        ExpToLevel = 50;
        LevelModifier = 1.05f;
    }
}

public enum StatName
{
    Accuracy,
    Defense,
    Vitality,
    Intellect,
    Dexterity,
    Strength,
    Endurance,
    Crit
}

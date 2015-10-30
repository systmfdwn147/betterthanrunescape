public class Abilities : ModifiedStat
{
    private bool _known;

    public Abilities()
    {
        _known = false;
        ExpToLevel = 25;
        LevelModifier = 1.1f;
    }

    public bool Known
    {
        get { return _known; }
        set { _known = value; }
    }
}

public enum SkillName
{
    Putabilityshithere,
    andhere
}

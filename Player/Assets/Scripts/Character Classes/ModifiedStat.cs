﻿using System.Collections.Generic;

public class ModifiedStat : BaseStat
{
    private List<ModifyingStat> _mods;       //A list of Attributes that modify this stat
    private int _modValue;                      //The amount added to the baseValue from the modifiers

    public ModifiedStat()
    {
        _mods = new List<ModifyingStat>();
        _modValue = 0;
    }

    public void AddModifier(ModifyingStat mod)
    {
        _mods.Add(mod);
    }

    private void CalculateModValue()
    {
        _modValue = 0;

        if (_mods.Count > 0)
            foreach (ModifyingStat att in _mods)
                _modValue += (int)(att.stat.AdjustedBaseValue * att.ratio);
    }

    public new int AdjustedBaseValue
    {
        get { return BaseValue + BuffValue + _modValue; }
    }

    public void Update()
    {
        CalculateModValue();
    }
}

public struct ModifyingStat
{
    public Stat stat;
    public float ratio;
}

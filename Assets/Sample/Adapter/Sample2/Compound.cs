using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compound
{
    protected string _chemical;
    protected float _boilingPoint;
    protected float _meltingPoint;
    protected double _molecularWeight;
    protected string _molecularFormula;

    public Compound(string chemical)
    {
        _chemical = chemical;
    }

    public virtual void Display()
    {
        Debug.Log("\nCompound:  " + _chemical + "------");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RichCompound : Compound
{
    private ChemicalDatabank _bank;
    
    public RichCompound(string chemical) : base(chemical)
    {
        
    }
    
    public override void Display()
    {
        // The Adaptee
        _bank = new ChemicalDatabank();

        _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
        _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
        _molecularWeight = _bank.GetMolecularWeight(_chemical);
        _molecularFormula = _bank.GetMolecularStructure(_chemical);

        base.Display();
        Debug.Log(" Formula: " + _molecularFormula);
        Debug.Log(" Weight : " + _molecularWeight);
        Debug.Log(" Melting Pt: " + _meltingPoint);
        Debug.Log(" Boiling Pt: " + _boilingPoint);
    }
}
using System;
using UnityEngine;

public class PrimitiveElement : DrawingElement
{
    public PrimitiveElement(string name) : base(name)
    {
    }

    public override void Add(DrawingElement d)
    {
        Debug.Log("Cannot add to a PrimitiveElement");
    }

    public override void Remove(DrawingElement d)
    {
        Debug.Log("Cannot remove from a PrimitiveElement");
    }

    public override void Display(int indent)
    {
        Debug.Log(new String('-', indent) + " " + _name);
    }
}
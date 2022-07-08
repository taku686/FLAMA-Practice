using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DrawingElement
{
    protected string _name;

    public DrawingElement(string name)
    {
        _name = name;
    }

    public abstract void Add(DrawingElement d);
    public abstract void Remove(DrawingElement d);
    public abstract void Display(int indent);
}
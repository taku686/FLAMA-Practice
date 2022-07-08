using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeElement : DrawingElement
{
    private readonly List<DrawingElement> _elements = new List<DrawingElement>();

    public CompositeElement(string name) : base(name)
    {
    }

    public override void Add(DrawingElement d)
    {
        _elements.Add(d);
    }

    public override void Remove(DrawingElement d)
    {
        _elements.Remove(d);
    }

    public override void Display(int indent)
    {
        Debug.Log(new String('-', indent) +
                  "+ " + _name);

        // Display each child element on this node
        foreach (DrawingElement d in _elements)
        {
            d.Display(indent + 2);
        }
    }
}
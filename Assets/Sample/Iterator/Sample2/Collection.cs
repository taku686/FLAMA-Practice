using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Collection : IAbstractCollection
{
    private ArrayList _items = new ArrayList();
    public Iterator2 CreateIterator()
    {
        return new Iterator2(this);
    }

    public int Count => _items.Count;

    public object this[int index]
    {
        get => _items[index];
        set => _items.Add(value);
    }
}

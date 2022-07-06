using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Iterator2 : IAbstractIterator
{
    private Collection _collection;
    private int _current;
    private int _step = 1;

    public Iterator2(Collection collection)
    {
        _collection = collection;
    }

    public Item First()
    {
        _current = 0;
        return _collection[_current] as Item;
    }

    public Item Next()
    {
        _current += _step;
        if (!isDone)
            return _collection[_current] as Item;
        else
            return null;
    }

    public int Step
    {
        get => _step;
        set => _step = value;
    }

    public Item CurrentItem => _collection[_current] as Item;

    public bool isDone => _current >= _collection.Count;

}
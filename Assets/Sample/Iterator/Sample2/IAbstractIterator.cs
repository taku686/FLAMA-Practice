using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IAbstractIterator
{
    Item First();
    Item Next();
    bool isDone { get; }
    Item CurrentItem { get; }
}

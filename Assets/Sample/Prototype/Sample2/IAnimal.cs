using System;
using UnityEngine;

namespace Sample.Prototype.Sample2
{
    public interface IAnimal : ICloneable
    {
        object Clone();
    }
}
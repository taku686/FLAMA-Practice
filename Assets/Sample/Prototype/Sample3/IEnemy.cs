using System;
using UnityEngine;

namespace Sample.Prototype.Sample3
{
    public interface IEnemy : ICloneable
    {
        object Clone();
    }
}
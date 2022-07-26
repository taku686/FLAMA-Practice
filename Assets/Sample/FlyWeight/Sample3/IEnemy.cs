using UnityEngine;

namespace Sample.FlyWeight.Sample3
{
    public interface IEnemy
    {
        string Name { get; }
        void Attack();
    }
}
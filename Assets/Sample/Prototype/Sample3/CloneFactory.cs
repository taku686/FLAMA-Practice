using UnityEngine;

namespace Sample.Prototype.Sample3
{
    public class CloneFactory
    {
        public IEnemy GetClone(IEnemy enemy)
        {
            return (IEnemy)enemy.Clone();
        }
    }
}
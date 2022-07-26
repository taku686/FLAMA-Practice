using UnityEngine;

namespace Sample.Strategy.Sample4
{
    public class Blow : IAttack
    {
        public void Attack()
        {
            Debug.Log("打撃攻撃");
        }
    }
}
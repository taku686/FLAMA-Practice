using UnityEngine;

namespace Sample.Strategy.Sample4
{
    public class Slash : IAttack
    {
        public void Attack()
        {
            Debug.Log("斬撃攻撃");
        }
    }
}
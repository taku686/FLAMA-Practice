using UnityEngine;

namespace Sample.Strategy.Sample4
{
    public class Magic : IAttack
    {
        public void Attack()
        {
            Debug.Log("魔法攻撃");
        }
    }
}
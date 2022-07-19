using UnityEngine;

namespace Sample.FlyWeight.Sample2
{
    public class DiffusionBullet : IBullet
    {
        public void Shot()
        {
            Debug.Log("DiffusionBullet発射！！");
        }
    }
}
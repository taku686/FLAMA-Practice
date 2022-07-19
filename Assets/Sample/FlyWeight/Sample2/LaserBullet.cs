using UnityEngine;

namespace Sample.FlyWeight.Sample2
{
    public class LaserBullet : IBullet
    {
        public void Shot()
        {
            Debug.Log("LaserBullet発射！！");
        }
    }
}
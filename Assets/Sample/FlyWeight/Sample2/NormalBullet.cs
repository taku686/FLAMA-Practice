using UnityEngine;

namespace Sample.FlyWeight.Sample2
{
    public class NormalBullet : IBullet
    {
        public void Shot()
        {
            Debug.Log("NormalBullet発射！！");
        }
    }
}
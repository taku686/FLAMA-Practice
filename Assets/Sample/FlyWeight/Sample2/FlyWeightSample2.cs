using System;
using UnityEngine;

namespace Sample.FlyWeight.Sample2
{
    public class FlyWeightSample2 : MonoBehaviour
    {
        private void Start()
        {
            long beforeMemory = System.GC.GetTotalMemory(false);
            Debug.Log("生成前メモリー" + beforeMemory);
            BulletFactory factory = new BulletFactory();

            for (int i = 0; i < 10; i++)
            {
                IBullet normalBullet = factory.Shot("NormalBullet");
                normalBullet.Shot();
            }

            long afterMemory = System.GC.GetTotalMemory(false);
            Debug.Log("生成後使用メモリー" + afterMemory);
            long useMemory = afterMemory - beforeMemory;
            Debug.Log("使用メモリー" + useMemory);
        }
    }
}
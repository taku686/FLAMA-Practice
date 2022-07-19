using System;
using UnityEngine;

namespace Sample.FlyWeight
{
    public class Sample1 : MonoBehaviour
    {
        private void Start()
        {
            long beforeMemory = System.GC.GetTotalMemory(false);
            Debug.Log("生成前メモリ" + beforeMemory);
            for(int x= 0; x<=9; ++x)
            {
                //for文を使ってスライムを１０体生成　instantiate関数でも良い
                SlimeFlyWeight normalslime = new Slime();
            }
            long after_memory = System.GC.GetTotalMemory(false);
            Debug.Log ("生成後使用メモリ" + after_memory);
            long use_memory = after_memory - beforeMemory;
            Debug.Log ("使用メモリ" + use_memory);
        }
    }
}
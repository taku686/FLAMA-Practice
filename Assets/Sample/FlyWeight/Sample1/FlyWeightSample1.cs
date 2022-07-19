using System.Collections;
using System.Collections.Generic;
using ModestTree;
using Sample.FlyWeight;
using UnityEngine;

public class FlyWeightSample1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        long beforeMemory = System.GC.GetTotalMemory(false);
        Debug.Log("生成前メモリ" + beforeMemory);
        SlimeFactory factory = new SlimeFactory();

        for (int i = 0; i < 9; i++)
        {
            SlimeFlyWeight normaliSlime = factory.GetFlyweight("NormalSlime");
        }

        long afterMemory = System.GC.GetTotalMemory(false);
        Debug.Log("生成後使用メモリー" + afterMemory);
        long useMemory = afterMemory - beforeMemory;
        Debug.Log("使用メモリー" + useMemory);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Sample.UniRxUniTask.Sample2
{
    public class UniTaskSample1_0 : MonoBehaviour
    {
        async UniTask TestTask(double sec = 1)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(sec));
            Debug.Log("TestTask" + sec);
        }

        private async void Start()
        {
            await TestTask();

            await UniTask.WhenAll(
                TestTask(2),
                TestTask(3),
                TestTask(4)
            );
        }
    }
}
using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Sample.UniRxUniTask.Sample3
{
    public class UniTaskSample3 : MonoBehaviour
    {
        private async UniTask Start()
        {
            await StartTween();
        }

        async UniTask StartTween()
        {
            await transform.DOLocalMove(Vector3.one, 1f);
        }
    }
}
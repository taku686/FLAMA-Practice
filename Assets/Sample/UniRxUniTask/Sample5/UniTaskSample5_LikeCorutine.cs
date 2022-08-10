using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Sample.UniRxUniTask.Sample5
{
    public class UniTaskSample5_LikeCorutine : MonoBehaviour
    {
        private void Start()
        {
            DoAsync(this.GetCancellationTokenOnDestroy()).Forget();
        }

        private async UniTaskVoid DoAsync(CancellationToken token)
        {
            await UniTask.Yield();

            await UniTask.Yield(token);

            await UniTask.Yield(PlayerLoopTiming.FixedUpdate, token);
            await UniTask.WaitForFixedUpdate(token);

            await UniTask.NextFrame(token);
            await UniTask.NextFrame(PlayerLoopTiming.FixedUpdate, token);

            await UniTask.Delay(TimeSpan.FromSeconds(1f), cancellationToken: token);
        }
    }
}
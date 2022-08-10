using System;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using  UnityEngine.Networking;

using UnityEngine;

namespace Sample.UniRxUniTask.Sample6
{
    public class Sample6_Awaiter : MonoBehaviour
    {
        private void Start()
        {
            DoAsync(this.GetCancellationTokenOnDestroy()).Forget();
        }

        private async UniTaskVoid DoAsync(CancellationToken token)
        {
            try
            {
                var gameObject =
                    (await Resources.LoadAsync<GameObject>("Sphere").ToUniTask(cancellationToken: token)) as GameObject;
                var result = await GetHttpAsync("https://www.google.com/", token);
            }
            catch (Exception e)when (!(e is OperationCanceledException))
            {
            }
        }

        private async UniTask<string> GetHttpAsync(string uri, CancellationToken token)
        {
            using var uwr = UnityWebRequest.Get(uri);
            await uwr.SendWebRequest().ToUniTask(cancellationToken: token);
            return  
           

        }
    }
}
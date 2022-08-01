using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Sample.UniRxUniTask.Sample1
{
    public class UniRxSample1 : MonoBehaviour
    {
        private readonly Subject<Unit> _inputKeyA = new Subject<Unit>();

        private void Start()
        {
            _inputKeyA.AddTo(this);

            this.UpdateAsObservable()
                .Where(_ => Input.GetKey(KeyCode.A))
                .ThrottleFirst(TimeSpan.FromSeconds(1f))
                .Subscribe(_ => { Debug.Log("Pressed A Key"); }).AddTo(this);
        }
    }
}
using System;
using UnityEngine;
using  DG.Tweening;
using  UniRx;
using UniRx.Triggers;

namespace mvp
{
    public class Enemy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            this.UpdateAsObservable()
                .Where(_ => Input.GetKey(KeyCode.Space))
                .ThrottleFirst(TimeSpan.FromSeconds(0.5f))
                .Subscribe(_ =>
                {
                    Jump();
                }).AddTo(this);

        }

        private void Jump()
        {
            this.transform.DOJump(new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z),
                1,
                1,
                1f);
        }
    }
}
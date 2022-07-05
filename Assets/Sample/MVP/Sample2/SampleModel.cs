using System;
using UnityEngine;
using  UniRx;

namespace mvp2
{
    public class SampleModel : MonoBehaviour
    {
        public IReactiveProperty<int> Count =>_count;

        public readonly int MaxCount = 100;

        private readonly IntReactiveProperty _count = new IntReactiveProperty(0);

        public void SetCount(int value)
        {
            value = Mathf.Clamp(value, 0, MaxCount);
            _count.Value = value;
        }

        private void OnDestroy()
        {
            _count.Dispose();
        }
    }
}
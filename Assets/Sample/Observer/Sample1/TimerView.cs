using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Sample.Observer.Sample1
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private ObserverSample1 _sample1;
        [SerializeField] private Text counterText;

        private void Start()
        {
            _sample1.OnTimedChanged.Subscribe(time => { counterText.text = time.ToString(); }).AddTo(this);
        }
    }
}
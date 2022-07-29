using System;
using System.Collections;
using UniRx;
using UnityEngine;

namespace Sample.Observer.Sample1
{
    public class ObserverSample1 : MonoBehaviour
    {
        private Subject<int> _timerSubject = new Subject<int>();

        public IObservable<int> OnTimedChanged
        {
            get => _timerSubject;
        }

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(TimerCoroutine());
        }

        IEnumerator TimerCoroutine()
        {
            var time = 100;
            while (time > 0)
            {
                time--;

                _timerSubject.OnNext(time);

                yield return new WaitForSeconds(1);
            }
        }
    }
}
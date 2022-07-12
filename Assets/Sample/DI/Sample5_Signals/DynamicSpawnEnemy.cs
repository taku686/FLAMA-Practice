using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample5
{
    public class DynamicSpawnEnemy : MonoBehaviour
    {
        private SignalBus _signalBus;

        [Inject]
        void Initialize(SignalBus signalBus)
        {
            _signalBus = signalBus;
            _signalBus.Subscribe<PauseSignal>(OnPause);
        }

        void OnDestroy()
        {
            // 明示的に購読解除しないと残りっぱなしになる
         //   _signalBus.UnSubscribe<PauseSignal>(OnPause);
        }

        private void OnPause(PauseSignal signal) => print("Pause!!");
    }
}
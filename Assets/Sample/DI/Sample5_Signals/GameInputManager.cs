using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample5
{
    public class GameInputManager : MonoBehaviour
    {
        [Inject] private SignalBus _signalBus;

        private bool _isPause = false;

        private void Start()
        {
        
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (_isPause)
                {
                    // PauseEventを発行する
                    _signalBus.Fire<PauseSignal>();
                }
                else
                {
                    _signalBus.Fire<ResumeSignal>();
                }

                _isPause = !_isPause;
            }
        }
    }
}
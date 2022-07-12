using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample5
{
    public class PauseSignal
    {
    }

    public class ResumeSignal
    {
    }

    public class Player : MonoBehaviour, IPauseable
    {
        private bool _isPause = true;
       // [Inject] private GameInputManager _inputManager;
        // Update is called once per frame
        void Update()
        {
            if (!_isPause)
            {
                Debug.Log("Player停止中");
            }
        }

        public void OnPause(PauseSignal signal) => _isPause = true;


        public void OnResume(ResumeSignal signal) => _isPause = false;
    }
}
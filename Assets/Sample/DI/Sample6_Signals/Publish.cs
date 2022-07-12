using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample6
{
    public class Publish : MonoBehaviour
    {
        [Inject] private SignalBus _signalBus = default;

        // Start is called before the first frame update
        void Start()
        {
            _signalBus.Fire(new MessageSignal { Message = "Fire" });
        }
    }
}
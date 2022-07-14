using System;
using UnityEngine;
using Zenject;

namespace Sample.DI.Sample7
{
    public class Example : IInitializable, IDisposable, ITickable, ILateTickable, IFixedTickable
    {
        public void Initialize()
        {
            Debug.Log("Initialize.");
        }

        public void Dispose()
        {
            Debug.Log("Dispose");
        }

        public void Tick()
        {
            Debug.Log("Tick");
        }

        public void LateTick()
        {
            Debug.Log("LateTick");
        }

        public void FixedTick()
        {
            Debug.Log("FixedTick");
        }
    }
}
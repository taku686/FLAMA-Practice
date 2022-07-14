using System;
using UnityEngine;
using Zenject;

namespace Sample.DI.Sample8
{
    public class DISample8 : IInitializable, IDisposable, ITickable, ILateTickable, IFixedTickable
    {
        private GameObject obj;

        public void Initialize()
        {
            Debug.Log("Initialize");
            obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            obj.transform.position = Vector3.zero;
        }

        public void Dispose()
        {
            DestroyOnTime.Destroy(obj);
        }

        public void Tick()
        {
            if (obj == null)
            {
                return;
            }

            var hori = Input.GetAxis("Horizontal");
            var vert = Input.GetAxis("Vertical");
            if (hori != 0 || vert != 0)
            {
                obj.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
        }

        public void LateTick()
        {
        }

        public void FixedTick()
        {
        }
    }
}
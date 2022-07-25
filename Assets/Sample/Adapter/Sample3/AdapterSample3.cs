using System;
using UnityEngine;

namespace Sample.Adapter.Sample3
{
    public class AdapterSample3 : MonoBehaviour
    {
        private void Start()
        {
            Target target = new Adapter();

            target.TargetMethod1();
            target.TargetMethod2();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge.Sample1
{
    public class ConcreteImplementer : Implementer
    {
        public override void Execute()
        {
            Debug.Log("Execute");
        }
    }
}
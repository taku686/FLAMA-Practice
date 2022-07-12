using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge.Sample1
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementer impl) : base(impl)
        {
        }

        public void ExecuteFiveTimes()
        {
            for (int i = 0; i < 5; i++)
            {
                Execute();
            }
        }
    }
}
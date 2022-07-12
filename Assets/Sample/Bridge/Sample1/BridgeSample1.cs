using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge.Sample1
{
    public class BridgeSample1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var impl = new ConcreteImplementer();
            var abstraction = new Abstraction(impl);
            var refinedAbstraction = new RefinedAbstraction(impl);

            abstraction.Execute();
            refinedAbstraction.ExecuteFiveTimes();
        }
    }
}
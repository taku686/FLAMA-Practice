using System;
using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample3
{
    public class ChainSample3 : MonoBehaviour
    {
        private void Start()
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();

            handler1.SetHandler(handler2);

            handler1.Request(new SomeTask("TaskB"));
            handler1.Request(new SomeTask("TaskA"));
            handler1.Request(new SomeTask("TaskC"));
        }
    }
}
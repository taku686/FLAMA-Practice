using System;
using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample1
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            handler1.SetHandler(handler2);
            
            handler1.Request(new SomeTask("TaskB"));
            
        }
    }
}
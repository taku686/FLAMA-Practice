using System;
using UnityEngine;

namespace Sample.Proxy.Sample3
{
    public class ProxySample3 : MonoBehaviour
    {
        private void Start()
        {
            ISendable s = new MessagingProxy();
            s.Address = "128.0.0.2";
            s.SendMessage("Hello World");
        }
    }
}
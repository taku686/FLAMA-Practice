using System.Threading;
using UnityEngine;

namespace Sample.Proxy.Sample3
{
    public class RealMessaging : ISendable
    {
        private string _address;

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public RealMessaging()
        {
            Thread.Sleep(5 * 1000);
        }

        public void SendMessage(string message)
        {
            Debug.Log(_address + ": " + message);
        }
    }
}
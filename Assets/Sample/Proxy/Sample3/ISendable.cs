using UnityEngine;

namespace Sample.Proxy.Sample3
{
    public interface ISendable 
    {
        string Address { get; set; }
        void SendMessage(string message);
    }
}
using UnityEngine;

namespace Sample.Proxy.Sample3
{
    public class MessagingProxy : ISendable
    {
        private ISendable _real;

        public MessagingProxy()
        {
        }

        public string Address { get; set; }

        public void SendMessage(string message)
        {
            if (_real == null)
            {
                _real = new RealMessaging();
            }

            _real.Address = Address;
            _real.SendMessage(message);
        }
    }
}
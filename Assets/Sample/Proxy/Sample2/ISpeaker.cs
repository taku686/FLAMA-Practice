using UnityEngine;

namespace Proxy.Sample2
{
    public interface ISpeaker
    {
        public string Hello();
        public string Bye();
        public string Chat();
    }
}
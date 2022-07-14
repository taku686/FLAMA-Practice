using UnityEngine;

namespace Proxy.Sample2
{
    public class EnglishSpeaker : ISpeaker
    {
        public string Hello()
        {
            return "Hello!!";
        }

        public string Bye()
        {
            return "Good Bye!!";
        }

        public string Chat()
        {
            return "It's a good tenki";
        }
    }
}
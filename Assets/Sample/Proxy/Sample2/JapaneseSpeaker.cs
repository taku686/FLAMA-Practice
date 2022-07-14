using UnityEngine;

namespace Proxy.Sample2
{
    public class JapaneseSpeaker : ISpeaker
    {
        private readonly ISpeaker _english = new EnglishSpeaker();

        public string Hello()
        {
            return "こんにちは!!\n" + _english.Hello();
        }

        public string Bye()
        {
            return "さようなら!!\n" + _english.Bye();
        }

        public string Chat()
        {
            return "いいお天気ですね\n" + _english.Chat();
        }
    }
}
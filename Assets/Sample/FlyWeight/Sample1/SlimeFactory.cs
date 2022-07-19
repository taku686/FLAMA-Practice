using System.Collections.Generic;
using UnityEngine;

namespace Sample.FlyWeight
{
    public class SlimeFactory
    {
        private Dictionary<string, SlimeFlyWeight> _slimes = new Dictionary<string, SlimeFlyWeight>();

        public SlimeFactory()
        {
            _slimes.Add("NormalSlime", new Slime());
            _slimes.Add("MetalSlime", new MetalSlime());
            _slimes.Add("KingSlime", new KingSlime());
        }

        public SlimeFlyWeight GetFlyweight(string slimeName)
        {
            return _slimes[slimeName];
        }
    }
}
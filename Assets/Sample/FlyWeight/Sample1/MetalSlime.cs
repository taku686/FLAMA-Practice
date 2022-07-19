using UnityEngine;

namespace Sample.FlyWeight
{
    public class MetalSlime : SlimeFlyWeight
    {
        private int[] a = new int[1000];

        public void Appear()
        {
            Debug.Log("メタルスライムが現れた!!");
        }
    }
}
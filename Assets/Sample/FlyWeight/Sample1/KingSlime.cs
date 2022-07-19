using UnityEngine;

namespace Sample.FlyWeight
{
    public class KingSlime : SlimeFlyWeight
    {
        private int[] a = new int[1000];
        public void Appear()
        {
            Debug.Log("キングスライムが現れた!!");
        }
    }
}
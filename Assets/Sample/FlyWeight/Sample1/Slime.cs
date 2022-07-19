using UnityEngine;

namespace Sample.FlyWeight
{
    public class Slime : SlimeFlyWeight
    {
        private int[] a = new int[1000];
        public void Appear()
        {
            Debug.Log("スライムが現れた!!");
        }
    }
}
using UnityEngine;

namespace Sample.Adapter.Sample3
{
    public class Adaptee
    {
        public void MethodA()
        {
            Debug.Log("適応前メソッドA");
        }

        public void MethodB()
        {
            Debug.Log("適応前メソッドB");
        }
    }
}
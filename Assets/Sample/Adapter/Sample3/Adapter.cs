using UnityEngine;

namespace Sample.Adapter.Sample3
{
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public void TargetMethod1()
        {
            _adaptee.MethodA();
            Debug.Log("メソッドA適応");
        }

        public void TargetMethod2()
        {
            _adaptee.MethodB();
            Debug.Log("メソッドB適応");
        }
    }
}
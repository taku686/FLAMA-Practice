using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample3
{
    public class ConcreteHandler1 : Handler
    {
        protected override bool Resolve(SomeTask task)
        {
            if (task.Name != "TaskA") return false;

            Debug.Log($"{task.Name}を処理します。");
            return true;
        }
    }
}
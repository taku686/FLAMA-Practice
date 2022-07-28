using UnityEngine;

namespace Sample.Visitor.Sample3
{
    public class ConcreteVisitor : Visitor
    {
        public override void Visit(ConcreteElement element)
        {
            Debug.Log("Visit " + element.GetType().Name);
        }
    }
}
using UnityEngine;

namespace Sample.Visitor.Sample3
{
    public abstract class Visitor
    {
        public abstract void Visit(ConcreteElement element);
    }
}
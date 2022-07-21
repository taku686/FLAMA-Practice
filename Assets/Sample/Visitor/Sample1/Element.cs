using UnityEngine;

namespace Sample.Visitor.Sample1
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
using UnityEngine;

namespace Sample.Visitor.Sample3
{
    public interface IElement
    {
        public abstract void Accept(Visitor visitor);
    }
}
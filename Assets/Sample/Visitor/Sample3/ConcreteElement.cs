using Cysharp.Threading.Tasks.Triggers;
using UnityEngine;

namespace Sample.Visitor.Sample3
{
    public class ConcreteElement : IElement
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
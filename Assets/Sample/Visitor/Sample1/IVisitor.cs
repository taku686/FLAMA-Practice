using UnityEngine;

namespace Sample.Visitor.Sample1
{
    public interface IVisitor 
    {
        void Visit(Element element);
    }
}
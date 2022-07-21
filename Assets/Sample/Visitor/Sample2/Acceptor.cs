using UnityEngine;

namespace Sample.Visitor.Sample2
{
    public abstract class Acceptor : MonoBehaviour
    {
        public abstract void Accept(Visitor visitor);
    }
}
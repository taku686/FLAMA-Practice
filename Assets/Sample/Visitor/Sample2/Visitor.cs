using UnityEngine;

namespace Sample.Visitor.Sample2
{
    public abstract class Visitor : MonoBehaviour
    {
        public abstract void Visit(ItemAcceptor acceptor);
        public abstract void Visit(DoorAcceptor acceptor);
        public abstract void Visit(ActorAcceptor acceptor);
    }
}
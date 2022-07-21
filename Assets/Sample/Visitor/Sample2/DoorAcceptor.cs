using UnityEngine;

namespace Sample.Visitor.Sample2
{
    public class DoorAcceptor : Acceptor
    {
        public override void Accept(Visitor visitor)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}
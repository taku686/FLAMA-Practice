using UnityEngine;

namespace Sample.Visitor.Sample2
{
    public class ItemAcceptor : Acceptor
    {
        public override void Accept(Visitor visitor)
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
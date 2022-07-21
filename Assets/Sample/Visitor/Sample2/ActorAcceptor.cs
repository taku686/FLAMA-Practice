using UnityEngine;

namespace Sample.Visitor.Sample2
{
    public class ActorAcceptor : Acceptor
    {
        public GameObject text;
        public override void Accept(Visitor visitor)
        {
            text.SetActive(true);
        }
    }
}
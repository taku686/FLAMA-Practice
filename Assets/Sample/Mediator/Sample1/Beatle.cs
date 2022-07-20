using UnityEngine;

namespace Sample.Mediator.Sample1
{
    public class Beatle : Participant
    {
        public Beatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Debug.Log("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
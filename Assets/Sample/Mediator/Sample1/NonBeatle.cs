using UnityEngine;

namespace Sample.Mediator.Sample1
{
    public class NonBeatle : Participant
    {
        public NonBeatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Debug.Log("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
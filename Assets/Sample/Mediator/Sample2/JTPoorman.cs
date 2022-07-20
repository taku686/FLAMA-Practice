using UnityEngine;

namespace Sample.Mediator.Sample2
{
    public class JTPoorman : Colleague
    {
        public JTPoorman(Mediator mediator) : base(mediator)
        {
            Debug.Log("JT Poorman signed up with the stockexange");
        }
    }
}
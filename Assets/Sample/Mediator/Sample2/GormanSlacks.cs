using UnityEngine;

namespace Sample.Mediator.Sample2
{
    public class GormanSlacks : Colleague
    {
        public GormanSlacks(Mediator mediator) : base(mediator)
        {
            Debug.Log("Gorman Slacks signed up with the stockexange");
        }
    }
}
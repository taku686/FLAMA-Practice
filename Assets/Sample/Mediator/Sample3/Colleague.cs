using UnityEngine;

namespace Sample.Mediator.Sample3
{
    public abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}
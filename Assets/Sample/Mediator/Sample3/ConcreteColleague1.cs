﻿using UnityEngine;

namespace Sample.Mediator.Sample3
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Debug.Log("Colleague1 gets message: " + message);
        }
    }
}
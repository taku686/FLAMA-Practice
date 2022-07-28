using UnityEngine;

namespace Sample.Mediator.Sample3
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
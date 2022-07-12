using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge.Sample1
{
    public class Abstraction 
    {
        protected Implementer _impl;


        public Abstraction(Implementer impl)
        {
            _impl = impl;
        }

        public void Execute()
        {
            _impl.Execute();
        }
    }
}
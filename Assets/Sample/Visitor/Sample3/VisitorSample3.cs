using System;
using UnityEngine;

namespace Sample.Visitor.Sample3
{
    public class VisitorSample3 : MonoBehaviour
    {
        private void Start()
        {
            var visitor = new ConcreteVisitor();
            var element = new ConcreteElement();

            visitor.Visit(element);
        }
    }
}
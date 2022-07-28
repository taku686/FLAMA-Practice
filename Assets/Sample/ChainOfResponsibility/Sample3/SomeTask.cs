using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample3
{
    public class SomeTask
    {
        public string Name { get; }

        public SomeTask(string name) => Name = name;
    }
}
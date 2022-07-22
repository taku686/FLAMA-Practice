using UnityEngine;

namespace Sample.Composite.Sample3
{
    public interface Person
    {
        string Name { get; set; }
        Person Boss { get; set; }

        public void SelfIntroduction();
    }
}
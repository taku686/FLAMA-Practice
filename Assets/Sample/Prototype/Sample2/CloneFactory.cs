using UnityEngine;

namespace Sample.Prototype.Sample2
{
    public class CloneFactory 
    {
        public IAnimal GetClone(IAnimal animalSample)
        {
            return (IAnimal)animalSample.Clone();
        }
    }
}
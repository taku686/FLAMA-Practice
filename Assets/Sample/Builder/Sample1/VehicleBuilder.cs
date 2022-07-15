using UnityEngine;

namespace Sample.Builder.Sample1
{
    public abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        public Vehicle Vehicle => _vehicle;

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
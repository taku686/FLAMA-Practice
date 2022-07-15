using UnityEngine;

namespace Sample.Builder.Sample1
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            _vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            _vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "50 cc";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "0";
        }
    }
}
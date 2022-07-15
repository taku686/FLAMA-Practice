using UnityEngine;

namespace Sample.Builder.Sample1
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            _vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildFrame()
        {
            _vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "500 cc";
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
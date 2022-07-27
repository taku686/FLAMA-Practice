using UnityEngine;

namespace Sample.Builder.Sample3
{
    public class OldRobotBuilder : IRobotBuilder
    {
        protected Robot _robot { get; set; }

        public OldRobotBuilder()
        {
            _robot = new Robot();
        }

        public Robot GetRobot()
        {
            return _robot;
        }

        public void BuildRobotHead()
        {
            _robot.SetRobotHead("Old Head");
        }

        public void BuildRobotTorso()
        {
            _robot.SetRobotTorso("Old Torso");
        }

        public void BuildRobotArms()
        {
            _robot.SetRobotArms("Old Arms");
        }

        public void BuildRobotLegs()
        {
            _robot.SetRobotLegs("Roller Skates");
        }
    }
}
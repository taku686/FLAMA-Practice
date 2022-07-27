using UnityEngine;

namespace Sample.Builder.Sample3
{
    public class RobotEngineer 
    {
        public IRobotBuilder robotBuilder { get; protected set; }

        public RobotEngineer(IRobotBuilder builder)
        {
            this.robotBuilder = builder;
        }

        public Robot GetRobot()
        {
            return this.robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            this.robotBuilder.BuildRobotHead();
            this.robotBuilder.BuildRobotTorso();
            this.robotBuilder.BuildRobotArms();
            this.robotBuilder.BuildRobotLegs();
        }
    }
}
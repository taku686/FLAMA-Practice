using UnityEngine;

namespace Sample.Builder.Sample3
{
    public interface IRobotBuilder
    {
        Robot GetRobot();
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();
    }
}
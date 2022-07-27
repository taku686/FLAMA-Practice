using UnityEngine;

namespace Sample.Builder.Sample3
{
    public class BuilderSample3 : MonoBehaviour
    {
        void Start()
        {
            IRobotBuilder oldRobot = new OldRobotBuilder();
            RobotEngineer engineer = new RobotEngineer(oldRobot);
            engineer.MakeRobot();

            Robot firstRobot = engineer.GetRobot();
            Debug.Log("First Robot built");
            Debug.Log(firstRobot.ToStringEX());
        }
    }
}
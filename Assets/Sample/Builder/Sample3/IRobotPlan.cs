using UnityEngine;

namespace Sample.Builder.Sample3
{
    public interface IRobotPlan
    {
        void SetRobotHead(string head);
        void SetRobotTorso(string torso);
        void SetRobotArms(string arms);
        void SetRobotLegs(string legs);
    }
}
using UnityEngine;

namespace Sample.Builder.Sample3
{
    public class Robot : IRobotPlan
    {
        public string _head { get; protected set; }
        public string _torso { get; protected set; }
        public string _arms { get; protected set; }
        public string _legs { get; protected set; }

        public void SetRobotHead(string head)
        {
            _head = head;
        }

        public void SetRobotTorso(string torso)
        {
            _torso = torso;
        }

        public void SetRobotArms(string arms)
        {
            _arms = arms;
        }

        public void SetRobotLegs(string legs)
        {
            _legs = legs;
        }

        public string ToStringEX()
        {
            return "Head: " + _head + ", Torso: " + _torso + ", Arms: " + _arms + ", Legs: " + _legs;
        }
    }
}
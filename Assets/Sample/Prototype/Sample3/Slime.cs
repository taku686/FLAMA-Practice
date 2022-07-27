using System;
using Sample.Prototype.Sample2;
using UnityEngine;

namespace Sample.Prototype.Sample3
{
    public class Slime : IEnemy
    {
        public Slime()
        {
            Debug.Log("Made Slime");
        }

        public object Clone()
        {
            Slime slime = null;

            try
            {
                slime = (Slime)MemberwiseClone();
            }
            catch (Exception e)
            {
                Debug.Log("Error cloning Slime");
            }

            return slime;
        }

        public string ToStringEX()
        {
            return "Slime Attack!!";
        }
    }
}
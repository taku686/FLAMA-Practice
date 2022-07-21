using System;
using UnityEngine;

namespace Sample.Prototype.Sample2
{
    public class Sheep : IAnimal
    {
        public Sheep()
        {
            Debug.Log("Made Sheep");
        }

        public object Clone()
        {
            Sheep sheep = null;

            try
            {
                sheep = (Sheep)base.MemberwiseClone();
            }
            catch (Exception e)
            {
                Debug.Log("Error cloning Sheep");
            }

            return sheep;
        }

        public string ToStringEX()
        {
            return "Hello I'm a Sheep";
        }
    }
}
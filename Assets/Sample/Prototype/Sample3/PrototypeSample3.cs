using System;
using UnityEngine;

namespace Sample.Prototype.Sample3
{
    public class PrototypeSample3 : MonoBehaviour
    {
        private void Start()
        {
            CloneFactory factory = new CloneFactory();
            Slime slime = new Slime();
            Slime cloneSlime = (Slime)factory.GetClone(slime);

            Debug.Log(slime.ToStringEX());
            Debug.Log(cloneSlime.ToStringEX());
            Debug.Log("slime Hash: " + slime.GetHashCode() + " - cloneSlime Hash: " + cloneSlime.GetHashCode());
        }
    }
}
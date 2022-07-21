using UnityEngine;

namespace Sample.Prototype.Sample2
{
    public class PrototypeSample2 : MonoBehaviour
    {
        void Start()
        {
            CloneFactory factory = new CloneFactory();

            Sheep sally = new Sheep();

            Sheep clonedSheep = (Sheep)factory.GetClone(sally);

            Debug.Log("Sally: " + sally.ToStringEX());
            Debug.Log("Clone of Sally: " + clonedSheep.ToStringEX());
            Debug.Log("Sally Hash: " + sally.GetHashCode() + " - Cloned Sheep Hash: " + clonedSheep.GetHashCode());
        }
    }
}
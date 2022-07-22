using UnityEngine;

namespace Sample.Composite.Sample3
{
    public class Employee : Person
    {
        public Employee(string name)
        {
            _name = name;
        }

        private string _name;
        private Person _boss;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Person Boss
        {
            get => _boss;
            set => _boss = value;
        }

        public void SelfIntroduction()
        {
            Debug.Log("My name is" + _name + ". My boss is " + _boss.Name + ".");
        }
    }
}
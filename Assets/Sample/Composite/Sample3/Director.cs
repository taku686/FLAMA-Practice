using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sample.Composite.Sample3
{
    public class Director : Person
    {
        private List<Person> _employees = new List<Person>();
        private string _name;
        private Person _boss;

        public Director(string name)
        {
            _name = name;
        }

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

        public void Add(Person employee)
        {
            _employees.Add(employee);
            employee.Boss = this;
        }

        public void Remove(Person employee)
        {
            _employees.Remove(employee);
        }


        public void SelfIntroduction()
        {
            if (_boss != null)
            {
                Debug.Log("My name is " + _name + ". My boss is " + _boss.Name + ".");
            }
            else
            {
                Debug.Log("My name is " + _name + ".");
            }

            Debug.Log("Subordinate count is " + _employees.Count);
            foreach (Person employee in _employees)
            {
                employee.SelfIntroduction();
            }
        }
    }
}
using System;
using UnityEngine;

namespace Sample.Composite.Sample3
{
    public class CompositeSample3 : MonoBehaviour
    {
        private void Start()
        {
            Director director1 = new Director("Director1");
            Director director2 = new Director("Director2");

            Employee employee1 = new Employee("Employee1");
            Employee employee2 = new Employee("Employee2");
            Employee employee3 = new Employee("Employee3");
            
            director1.Add(director2);
            director1.Add(employee1);
            director2.Add(employee2);
            director2.Add(employee3);
            
            director1.SelfIntroduction();
            
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge.Sample2
{
    public class BridgeSample2 : MonoBehaviour
    {
        void Start()
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
        }
    }
}
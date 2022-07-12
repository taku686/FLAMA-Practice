using System.Collections;
using System.Collections.Generic;
using Bridge.Sample2;
using UnityEngine;

namespace Bridge.Sample2
{
    public class Customers : CustomersBase
    {
        public Customers(string group) : base(group)
        {
        }
        
        public override void ShowAll()
        {
            // Add separator lines
            Debug.Log("------------------------");
            base.ShowAll();
            Debug.Log("------------------------");
        }
    }
}
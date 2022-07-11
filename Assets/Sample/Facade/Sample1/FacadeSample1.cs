using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeSample1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mortgage mortgage = new Mortgage();

        Customer customer = new Customer("Taku");
        bool eligible = mortgage.IsEligible(customer, 125000);
        Debug.Log("\n" + customer.name + " has been " + (eligible ? "Approved" : "Rejected"));
    }
}
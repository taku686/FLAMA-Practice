using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer 
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public string name => _name;
}

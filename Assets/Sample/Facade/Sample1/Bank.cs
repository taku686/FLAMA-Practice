using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank 
{
    public bool HasSufficientSavings(Customer c,int amount)
    {
        Debug.Log("Check bank for " + c.name);
        return true;
    }
}

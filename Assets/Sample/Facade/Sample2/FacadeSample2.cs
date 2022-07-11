using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeSample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BankAccountFacade bankAccount = new BankAccountFacade(12345678, 1234);

        Debug.Log("\"I want to withdraw $50 dollars!\"");
        bankAccount.WithdrawCash(50.00);

        Debug.Log("\"Mh ok now let me withdraw $5000 dollars!?\"");
        bankAccount.WithdrawCash(5000.00);

        Debug.Log("\"What tf... maybe save some cash, here are $300 bucks ;-)\"");
        bankAccount.DepositCash(300.00);
    }
}
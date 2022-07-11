using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortgage
{
    private Bank _bank = new Bank();
    private Loan _loan = new Loan();
    private Credit _credit = new Credit();

    public bool IsEligible(Customer cust, int amount)
    {
        Debug.Log(cust.name + "Applies for" + amount + " loan\n");

        bool eligible = true;

        if (!_bank.HasSufficientSavings(cust, amount))
        {
            eligible = false;
        }
        else if (!_loan.HasNoBadLoans(cust))
        {
            eligible = false;
        }
        else if (!_credit.HasGoodCredit(cust))
        {
            eligible = false;
        }

        return eligible;
    }
}
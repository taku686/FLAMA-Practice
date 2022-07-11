using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundsCheck 
{
   private double cashInAccount = 1000.00;

   public double GetCashInAccount()
   {
      return cashInAccount;
   }

   protected void DecreaseCashInAccount(double cash)
   {
      cashInAccount -= cash;
   }

   protected void IncreaseCashInAccount(double cash)
   {
      cashInAccount += cash;
   }

   public bool HaveEnoughMoney(double cashToWithdraw)
   {
      if (cashToWithdraw > GetCashInAccount())
      {
         Debug.Log("You don't have enough money");
         return false;
      }
      else
      {
         return true;
      }
   }

   public void MakeDeposit(double cash)
   {
      IncreaseCashInAccount(cash);
      Debug.Log("Deposit complete. Current Balance is: " + GetCashInAccount());
   }

   public void WithdrawMoney(double cash)
   {
      DecreaseCashInAccount(cash);
      //Debug.Log();
   }
}

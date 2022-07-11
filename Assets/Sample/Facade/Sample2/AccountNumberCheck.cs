using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountNumberCheck 
{
   private int accountNumber = 12345678;

   public int GetAccountNumber()
   {
      return accountNumber;
   }

   public bool AccountActive(int accNumber)
   {
      if (accNumber == accountNumber)
         return true;
      else
         return false;
   }
}

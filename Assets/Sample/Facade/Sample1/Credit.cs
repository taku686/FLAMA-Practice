using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit 
{
   public bool HasGoodCredit(Customer c)
   {
      Debug.Log("Check credit for " + c.name);
      return true;
   }
}

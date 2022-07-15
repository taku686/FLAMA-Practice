using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample2
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Debug.Log(this.GetType().Name + " approved request# " + purchase.Number);
            }
            else
            {
                Debug.Log("Request# " + purchase.Number + "requires an executive meeting!");
            }
        }
    }
}
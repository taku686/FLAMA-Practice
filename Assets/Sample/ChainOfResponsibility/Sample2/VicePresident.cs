using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample2
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Debug.Log(this.GetType().Name + " approved request# " + purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}
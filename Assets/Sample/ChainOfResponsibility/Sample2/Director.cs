using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample2
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Debug.Log(this.GetType().Name+" approved request# "+purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}
using UnityEngine;

namespace Sample.Mediator.Sample2
{
    public class MediatorSample2 : MonoBehaviour
    {
        void Start()
        {
            StockMediator nyse = new StockMediator();
            GormanSlacks broker = new GormanSlacks(nyse);
            JTPoorman broker2 = new JTPoorman(nyse);

            nyse.AddColleague(broker);
            nyse.AddColleague(broker2);
            
            broker.SaleOffer(Stock.MSFT, 100);
            broker.SaleOffer(Stock.GOOG, 50);

            broker2.BuyOffer(Stock.MSFT, 100);
            broker2.SaleOffer(Stock.NRG, 10);

            broker.BuyOffer(Stock.NRG, 10);
            broker.BuyOffer(Stock.NRG, 50);

            nyse.PrintStockOfferings();
        }
    }
}
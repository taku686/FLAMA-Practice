using UnityEngine;

namespace Sample.Mediator.Sample2
{
    public interface Mediator 
    {
        void AddColleague(Colleague colleague);
        void SaleOffer(Stock stock, int shares, int code);
        void BuyOffer(Stock stock, int shares, int code);
    }
}
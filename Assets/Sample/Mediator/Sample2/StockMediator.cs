using System.Collections.Generic;
using UnityEngine;

namespace Sample.Mediator.Sample2
{
    public class StockMediator : Mediator
    {
        private List<Colleague> _colleagues;
        private List<StockOffer> _buyOffers;
        private List<StockOffer> _sellOffers;

        private int _colleagueCodes = 0;
        

        public StockMediator()
        {
            _colleagues = new List<Colleague>();
            _buyOffers = new List<StockOffer>();
            _sellOffers = new List<StockOffer>();
        }

     
        
       public void AddColleague(Colleague colleague)
        {
            this._colleagues.Add(colleague);
            _colleagueCodes += 1;
            colleague.SetCode(_colleagueCodes);
        }

        public void SaleOffer(Stock stock, int shares, int code)
        {
            bool stockSold = false;

            // see if someone is willing to buy:
            for (int i = 0; i < _buyOffers.Count; i++)
            {
                StockOffer offer = _buyOffers[i];
                // check if the stock is the same:
                if (offer._stock == stock && offer._stockShares == shares)
                {
                    Debug.Log(shares + " shares of " + stock + " stocks sold to colleague with code " + code);

                    _buyOffers.Remove(offer);
                    stockSold = true;
                }

                if (stockSold) break;
            }

            if (!stockSold)
            {
                Debug.Log(shares + " shares of " + stock + " stocks added to inventory");
                StockOffer offer = new StockOffer(shares, stock, code);
                _sellOffers.Add(offer);
            }
        }

        public void BuyOffer(Stock stock, int shares, int code)
        {
            bool stockBought = false;

            // see if someone is willing to buy:
            for (int i = 0; i < _sellOffers.Count; i++)
            {
                StockOffer offer = _sellOffers[i];
                // check if the stock is the same:
                if (offer._stock == stock && offer._stockShares == shares)
                {
                    Debug.Log(shares + " shares of " + stock + " stocks bought by colleague with code " + code);

                    _sellOffers.Remove(offer);
                    stockBought = true;
                }

                if (stockBought) break;
            }

            if (!stockBought)
            {
                Debug.Log(shares + " shares of " + stock + " stocks added to inventory");
                StockOffer offer = new StockOffer(shares, stock, code);
                _buyOffers.Add(offer);
            }
        }
        
        public void PrintStockOfferings()
        {
            Debug.Log("For Sale: " + _sellOffers.Count);
            foreach (StockOffer offer in _sellOffers)
            {
                Debug.Log(offer._stock + " - " + offer._stockShares + " - " + offer._colleagueCode);
            }


            Debug.Log("For Buy: " + _buyOffers.Count);
            foreach (StockOffer offer in _buyOffers)
            {
                Debug.Log(offer._stock + " - " + offer._stockShares + " - " + offer._colleagueCode);
            }
        }
    }
}
using UnityEngine;

namespace Sample.Mediator.Sample2
{
    public class StockOffer 
    {
        public  int _stockShares { get; private set; }
        public  Stock _stock { get; private set; }
        public  int _colleagueCode { get; private set; }


        public StockOffer(int numOfShares, Stock stock, int collCode)
        {
            _stockShares = numOfShares;
            _stock = stock;
            _colleagueCode = collCode;
        }
    }

    public enum Stock
    {
        MSFT,
        GOOG,
        NRG
    }
}
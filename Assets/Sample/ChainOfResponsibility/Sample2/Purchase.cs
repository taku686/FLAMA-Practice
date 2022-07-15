using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample2
{
    public class Purchase 
    {
        private int _number;
        private double _amount;
        private string _purpose;

        public Purchase(int number, double amount, string purpose)
        {
            _number = number;
            _amount = amount;
            _purpose = purpose;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public double Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public string Purpose
        {
            get => _purpose;
            set => _purpose = value;
        }
    }
}
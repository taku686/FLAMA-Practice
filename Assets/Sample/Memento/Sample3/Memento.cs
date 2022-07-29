using UnityEngine;

namespace Sample.Memento.Sample3
{
    public class Memento 
    {
        private string _name;
        private string _phone;
        private double _budget;

        public Memento(string name, string phone, double budget)
        {
            _name = name;
            _phone = phone;
            _budget = budget;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public double Budget
        {
            get => _budget;
            set => _budget = value;
        }
        
        
    }
}
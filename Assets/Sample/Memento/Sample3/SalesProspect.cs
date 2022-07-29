using UnityEngine;

namespace Sample.Memento.Sample3
{
    public class SalesProspect
    {
        private string _name;
        private string _phone;
        private double _budget;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Debug.Log("Name: " + _name);
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Debug.Log("Phone: " + _phone);
            }
        }

        public double Budget
        {
            get => _budget;
            set
            {
                _budget = value;
                Debug.Log("Budget: " + _budget);
            }
        }

        public Memento SaveMemento()
        {
            Debug.Log("\nSaving state --\n");
            return new Memento(_name, _phone, _budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Debug.Log("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}
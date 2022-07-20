using UnityEngine;

namespace Sample.Memento.Sample1
{
    public class SalesProspect 
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Debug.Log("Name:  " + _name);
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Debug.Log("Phone: " + _phone);
            }
        }

        // Gets or sets budget
        public double Budget
        {
            get => _budget;
            set
            {
                _budget = value;
                Debug.Log("Budget: " + _budget);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Debug.Log("\nSaving state --\n");
            return new Memento(_name, _phone, _budget);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Debug.Log("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }
}
using UnityEngine;

namespace Sample.Visitor.Sample1
{
    public class Employee : Element
    {
        private string _name;
        private double _income;

        public Employee(string name, double income, int vacationDays)
        {
            _name = name;
            _income = income;
            _vacationDays = vacationDays;
        }

        private int _vacationDays;

        public double Income
        {
            get => _income;
            set => _income = value;
        }

        public int VacationDays
        {
            get => _vacationDays;
            set => _vacationDays = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
using UnityEngine;

namespace Sample.Visitor.Sample1
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            Debug.Log(employee.GetType().Name+" "+ employee.Name+"'s new income: "+employee.Income);
        }
    }
}
using UnityEngine;

namespace Sample.Visitor.Sample1
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Provide 3 extra vacation days
            employee.VacationDays += 3;
            Debug.Log(employee.GetType().Name + " " + employee.Name + "'s new vacation days:" + employee.VacationDays);
        }
    }
}
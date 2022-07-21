using UnityEngine;

namespace Sample.Visitor.Sample1
{
    public class VisitorSample1 : MonoBehaviour
    {
        void Start()
        {
            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

        }
    }
}
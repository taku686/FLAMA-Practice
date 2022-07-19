using UnityEngine;

namespace Sample.Interpreter.Sample2
{
    public class HelloExpression : GreetingExpression
    {
        public override string Hello()
        {
            return "Hello";
        }

        public override string GoodMorning()
        {
            return "";
        }

        public override string GoodBye()
        {
            return "";
        }
    }
}
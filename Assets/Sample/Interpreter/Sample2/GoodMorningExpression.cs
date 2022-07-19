using UnityEngine;

namespace Sample.Interpreter.Sample2
{
    public class GoodMorningExpression : GreetingExpression
    {
        public override string Hello()
        {
            return "";
        }

        public override string GoodMorning()
        {
            return "Good Morning";
        }

        public override string GoodBye()
        {
            return "";
        }
    }
}
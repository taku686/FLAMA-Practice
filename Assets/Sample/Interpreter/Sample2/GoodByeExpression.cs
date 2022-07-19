using UnityEngine;

namespace Sample.Interpreter.Sample2
{
    public class GoodByeExpression : GreetingExpression
    {
        public override string Hello()
        {
            return "";
        }

        public override string GoodMorning()
        {
            return "";
        }

        public override string GoodBye()
        {
            return "Good Bye";
        }
    }
}
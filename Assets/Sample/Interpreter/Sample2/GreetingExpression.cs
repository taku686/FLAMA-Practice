using UnityEngine;

namespace Sample.Interpreter.Sample2
{
    public abstract class GreetingExpression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Hello()))
            {
                context.Output = "こんにちは";
            }
            else if (context.Input.StartsWith(GoodMorning()))
            {
                context.Output = "おはよう";
            }
            else if (context.Input.StartsWith(GoodBye()))
            {
                context.Output = "またね";
            }
        }

        public abstract string Hello();
        public abstract string GoodMorning();
        public abstract string GoodBye();
    }
}
using System.Collections.Generic;
using UnityEngine;

namespace Sample.Interpreter.Sample1
{
    public class InterpreterSample1 : MonoBehaviour
    {
        void Start()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Debug.Log(roman + " = " + context.Output);
        }
    }
}
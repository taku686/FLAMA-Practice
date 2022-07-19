using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sample.Interpreter.Sample2
{
    public class InterpreterSample2 : MonoBehaviour
    {
        private void Start()
        {
            string greeting = "Hello";
            Context context = new Context(greeting);

            List<GreetingExpression> tree = new List<GreetingExpression>();
            tree.Add(new GoodMorningExpression());
            tree.Add(new GoodByeExpression());
            tree.Add(new HelloExpression());

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Debug.Log(greeting + context.Output);
        }
    }
}
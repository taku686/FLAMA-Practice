using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyTest : MonoBehaviour
{
    private void Start()
    {
        Context context;

        context = new Context(new ConcreteStrategyA());
        context.ContextInterface();
        context = new Context(new ConcreteStrategyB());
        context.ContextInterface();
        context = new Context(new ConcreteStrategyC());
        context.ContextInterface();
    }
}
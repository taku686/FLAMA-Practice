using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Context
{
    private Strategy _strategy;
    public Context(Strategy strategy)
    {
        this._strategy = strategy;
    }

    public void ContextInterface()
    {
        _strategy.AlgorithmInterface();
    }
}

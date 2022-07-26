using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ConcreteStrategyB : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.Log("アルゴリズムB");
    }
}
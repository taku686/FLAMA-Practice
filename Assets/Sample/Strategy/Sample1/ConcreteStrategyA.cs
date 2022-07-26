using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ConcreteStrategyA : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.Log("アルゴリズムA");
    }
}

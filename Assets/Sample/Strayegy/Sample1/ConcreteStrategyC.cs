using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ConcreteStrategyC : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.Log("アルゴリズムC");
    }
}

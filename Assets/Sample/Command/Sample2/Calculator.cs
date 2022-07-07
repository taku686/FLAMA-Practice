using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator
{
    private int _curr = 0;

    public void Operation(char @operator,int operand)
    {
        switch (@operator)
        {
            case '+': _curr += operand; break;
            case '-': _curr -= operand; break;
            case '*': _curr *= operand; break;
            case '/': _curr /= operand; break;
        }
        Debug.Log("Current value = " + _curr+ " ( following "+ @operator+operand+" )");
    }
}

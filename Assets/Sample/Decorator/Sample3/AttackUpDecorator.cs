using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUpDecorator : IStatus
{
    private readonly IStatus _decorator;

    public AttackUpDecorator(IStatus decorator)
    {
        _decorator = decorator;
    }
    public int Life => _decorator.Life;
    public int Attack => _decorator.Attack * 2;
}

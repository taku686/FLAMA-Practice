using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : PlayerActionAttr
{
    public Poison(IPlayerAction playerAction)
    {
        base._playerAction = playerAction;
    }

    public override void Attack()
    {
        _playerAction.Attack();
        Debug.Log("加えて毒属性のダメージ!!");
    }
}

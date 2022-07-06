using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : PlayerActionAttr
{
    public Water(IPlayerAction playerAction)
    {
        base._playerAction = playerAction;
    }

    public override void Attack()
    {
        _playerAction.Attack();
        Debug.Log("水属性攻撃!!");
    }
}

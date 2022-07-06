using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerActionAttr : IPlayerAction
{
    protected IPlayerAction _playerAction;
    public abstract void Attack();
}

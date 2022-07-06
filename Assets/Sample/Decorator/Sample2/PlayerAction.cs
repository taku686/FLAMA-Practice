using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : IPlayerAction
{
    public void Attack()
    {
        Debug.Log("攻撃します!!");
    }
}
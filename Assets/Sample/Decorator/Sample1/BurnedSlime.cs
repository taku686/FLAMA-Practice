using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnedSlime : CharacterDecorator
{
    public BurnedSlime(ICharacter character) : base(character)
    {
        
    }


    public override void Attack()
    {
        base.Attack();
        Debug.Log("火傷状態になった");
    }
}

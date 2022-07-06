using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDecorator : ICharacter
{
    private readonly ICharacter _character;

    public CharacterDecorator(ICharacter character)
    {
        _character = character;
    }
    public virtual void Attack()
    {
        _character.Attack();
    }
}

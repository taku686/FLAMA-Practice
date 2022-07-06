using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private Slime _slime;
    private BurnedSlime _burnedSlime;

    private void Start()
    {
        _slime = new Slime();
        _burnedSlime = new BurnedSlime(_slime);
        _slime.Attack();
        _burnedSlime.Attack();
    }
}
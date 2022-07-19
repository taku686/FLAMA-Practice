using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : IBulletBase
{
    private GameObject _prefab;
    private int _attack = 1;
    public string Name => "NormalBullet";

    public GameObject prefab
    {
        get => _prefab;
        set => _prefab = value;
    }

    public int Attack
    {
        get =>  _attack;
        set => _attack = value;
    }
}
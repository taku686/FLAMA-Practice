using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : IBulletBase
{
    private GameObject _prefab;
    public string Name => "NormalBullet";

    public GameObject prefab
    {
        get => _prefab;
        set => _prefab = value;
    }
    
    
}

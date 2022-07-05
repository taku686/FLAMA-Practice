using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : IBulletBase
{
    private GameObject _prefab;
    public string Name
    {
        get
        {
            return "NormalBullet";
        }
    }

    public GameObject prefab
    {
        get
        {
            return _prefab;
        }
        set
        {
            _prefab = value;
        }
    }
}

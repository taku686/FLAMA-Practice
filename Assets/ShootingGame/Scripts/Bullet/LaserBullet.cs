using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : IBulletBase
{
    private GameObject _prefab;
    public string Name
    {
        get
        {
            return "LaserBullet";
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

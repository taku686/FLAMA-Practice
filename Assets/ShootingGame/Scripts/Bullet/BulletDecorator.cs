using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDecorator : IBulletBase
{
    protected IBulletBase _bulletBase;
    public string Name { get; }
    public GameObject prefab { get; set; }
    public int Attack { get; set; }
}
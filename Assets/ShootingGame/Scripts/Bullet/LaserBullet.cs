using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : BulletDecorator
{
    public LaserBullet(IBulletBase bulletBase)
    {
        _bulletBase = this;
        _bulletBase.Attack = bulletBase.Attack * 2;
    }
}
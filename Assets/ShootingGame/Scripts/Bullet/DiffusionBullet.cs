using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffusionBullet : BulletDecorator
{
    public DiffusionBullet(IBulletBase bulletBase)
    {
        _bulletBase = this;
        _bulletBase.Attack = bulletBase.Attack * 1;
    }
}
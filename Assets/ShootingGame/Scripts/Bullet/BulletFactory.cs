using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : IFactoryBase
{
    [SerializeField] List<GameObject> _bullets = new List<GameObject>();
    IBulletBase _bullet;
    NormalBullet _normalBullet;
    LaserBullet _laserBullet;
    DiffusionBullet _diffusionBullet;

    public void Initialize()
    {
        _normalBullet = new NormalBullet();
        _laserBullet = new LaserBullet(_normalBullet);
        _diffusionBullet = new DiffusionBullet(_normalBullet);
    }

    protected override IBulletBase MakeBullet(BulletType.BulletTypes type)
    {
        switch (type)
        {
            case BulletType.BulletTypes.NormalBullet:
                _bullet = _normalBullet;
                _bullet.prefab = _bullets[0];
                return _bullet;
            case BulletType.BulletTypes.LaserBullet:
                _bullet = _laserBullet;
                _bullet.prefab = _bullets[1];
                return _bullet;
            case BulletType.BulletTypes.DiffusionBullet:
                _bullet = _diffusionBullet;
                _bullet.prefab = _bullets[2];
                return _bullet;
            default:
                return null;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotManagement : MonoBehaviour
{
    private IShot _shot;
    private IBulletBase _bullet;
    private NormalShot _normalShot;
    private LaserShot _laserShot;
    private DiffusionShot _diffusionShot;
    private BulletFactory _bulletFactory;

    public void Initialize()
    {
        _bulletFactory = GameObject.FindGameObjectWithTag("Manager").GetComponent<BulletFactory>();
        _bulletFactory.Initialize();
        _normalShot = this.gameObject.AddComponent<NormalShot>();
        _laserShot = this.gameObject.AddComponent<LaserShot>();
        _diffusionShot = this.gameObject.AddComponent<DiffusionShot>();
        _shot = _normalShot;
        _bullet = _bulletFactory.GetItem(BulletType.BulletTypes.NormalBullet);
    }

    public void SetShot(ShotType.ShotTypes type)
    {
        switch (type)
        {
            case ShotType.ShotTypes.NormalShot:
                _shot = _normalShot;
                _bullet = _bulletFactory.GetItem(BulletType.BulletTypes.NormalBullet);
                break;
            case ShotType.ShotTypes.LaserShot:
                _shot = _laserShot;
                _bullet = _bulletFactory.GetItem(BulletType.BulletTypes.LaserBullet);
                break;
            case ShotType.ShotTypes.DiffusionShot:
                _shot = _diffusionShot;
                _bullet = _bulletFactory.GetItem(BulletType.BulletTypes.DiffusionBullet);
                break;
        }
    }

    public void Shot(PlayerModel player)
    {
        _shot.Shot(_bullet, player);
    }
}
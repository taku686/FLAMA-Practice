using System.Collections.Generic;
using UnityEngine;

namespace Sample.FlyWeight.Sample2
{
    public class BulletFactory 
    {
        public Dictionary<string, IBullet> _bullets = new Dictionary<string, IBullet>();

        public BulletFactory()
        {
            _bullets.Add("NormalBullet", new NormalBullet());
            _bullets.Add("LaserBullet", new LaserBullet());
            _bullets.Add("DiffusionBullet", new DiffusionBullet());
        }

        public IBullet Shot(string bulletName)
        {
            return _bullets[bulletName];
        }
    }
}
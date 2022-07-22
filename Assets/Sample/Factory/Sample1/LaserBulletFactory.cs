using UnityEngine;

namespace Sample.Factory.Sample1
{
    public class LaserBulletFactory : BaseBulletFactory
    {
        private int _bulletID = 0;

        public BaseBullet Create()
        {
            var bullet = new LaserBullet("LaserBullet", _bulletID);
            _bulletID++;
            return bullet;
        }
    }
}
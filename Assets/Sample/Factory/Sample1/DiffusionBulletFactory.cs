using UnityEngine;

namespace Sample.Factory.Sample1
{
    public class DiffusionBulletFactory : BaseBulletFactory
    {
        private int _bulletID = 0;

        public BaseBullet Create()
        {
            var bullet = new DiffusionBullet("DiffusionBullet", _bulletID);
            _bulletID++;
            return bullet;
        }
    }
}
using UnityEngine;

namespace Sample.Factory.Sample1
{
    public class NormalBulletFactory : BaseBulletFactory
    {
        private int _bulletID = 0;

        public BaseBullet Create()
        {
            var bullet = new NormalBullet("NormalBullet", _bulletID);
            _bulletID++;
            return bullet;
        }
    }
}
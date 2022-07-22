using System;
using UnityEngine;

namespace Sample.Factory.Sample1
{
    public class FactorySample1 : MonoBehaviour
    {
        private void Start()
        {
            var normalBulletFactory = new NormalBulletFactory();
            var laserBulletFactory = new LaserBulletFactory();
            var diffusionBulletFactory = new DiffusionBulletFactory();

            normalBulletFactory.Create().Shot();
            normalBulletFactory.Create().Shot();
            normalBulletFactory.Create().Shot();
            normalBulletFactory.Create().Shot();
            normalBulletFactory.Create().Shot();
            normalBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            laserBulletFactory.Create().Shot();
            diffusionBulletFactory.Create().Shot();
        }
    }
}
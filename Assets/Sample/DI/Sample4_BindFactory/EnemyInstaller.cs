using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample4
{
    public class EnemyInstaller : MonoInstaller
    {
        public bool UseOrc;

        public override void InstallBindings()
        {
            if (UseOrc)
            {
                Container.BindFactory<IEnemy, EnemyFactory>().To<Orc>();
            }
            else
            {
                Container.BindFactory<IEnemy, EnemyFactory>().To<Slime>();
            }
           
        }
    }
}
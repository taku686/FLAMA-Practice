using System.Collections;
using System.Collections.Generic;
using DI.Sample2;
using UnityEngine;
using Zenject;

namespace DI.Sample2
{
    public class MainGameInstaller : MonoInstaller<MainGameInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Player>().AsCached();
            Container.BindFactory<Enemy, Enemy.Factory>();
        }
    }
}
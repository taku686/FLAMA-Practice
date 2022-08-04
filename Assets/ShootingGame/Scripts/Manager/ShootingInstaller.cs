using System;
using ShootingGame.Scripts.Enemy;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace ShootingGame.Scripts.Manager
{
    public class ShootingInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _manager;
        [SerializeField] private GameObject _enemyFactory;
        private readonly string _enemyPrefabPath = "Enemy";

        public override void InstallBindings()
        {
            InstallToGeneralManager();
            InstallToEnemyManager();
            InstallToEnemyFactory();
        }

        private void InstallToGeneralManager()
        {
            Container.Bind<EnemyManager>()
                .FromComponentOn(_manager)
                .AsSingle();
        }

        private void InstallToEnemyManager()
        {
            Container.Bind<EnemyFactory>()
                .FromComponentOn(_enemyFactory)
                .AsSingle();
        }

        private void InstallToEnemyFactory()
        {
            Container.Bind<GameObject>().WithId("enemy")
                .FromResource(_enemyPrefabPath)
                .AsTransient();
        }
    }
}
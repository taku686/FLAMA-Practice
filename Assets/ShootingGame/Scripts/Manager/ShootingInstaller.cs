using System;
using ShootingGame.Scripts.Enemy;
using UnityEngine;
using Zenject;

namespace ShootingGame.Scripts.Manager
{
    public class ShootingInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _manager;
        [SerializeField] private GameObject _enemyFactory;
        private readonly string _enemyPrefabPath = "Enemy.prefab";

        public override void InstallBindings()
        {
            Container.Bind<EnemyManager>()
                .FromComponentOn(_manager)
                .AsSingle();
            Container.Bind<EnemyFactory>()
                .FromComponentOn(_enemyFactory)
                .AsSingle();
            Container.Bind<GameObject>()
                .FromResource(_enemyPrefabPath)
                .AsTransient();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample3
{
    public class EnemySpawner
    {
        [Inject] private Enemy.Factory _enemyFactory;
        private List<IEnemy> _enemies = new List<IEnemy>();

        public void Spawn()
        {
            var enemy = _enemyFactory.Create(Random.Range(1f, 100f));
            _enemies.Add(enemy);
        }
    }
}
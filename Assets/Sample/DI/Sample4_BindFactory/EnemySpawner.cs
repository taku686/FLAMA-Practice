using System.Collections;
using System.Collections.Generic;
using DI.Sample4;
using UnityEngine;

namespace DI.Sample4
{


    public class EnemySpawner : MonoBehaviour
    {
        private EnemyFactory _factory;
        private List<IEnemy> _enemies = new List<IEnemy>();

        public EnemySpawner(EnemyFactory factory)
        {
            _factory = factory;
        }

        public void Spawn()
        {
            var enemy = _factory.Create();
            _enemies.Add(enemy);
        }
    }
}
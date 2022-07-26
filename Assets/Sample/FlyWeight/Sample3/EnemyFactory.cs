using System.Collections.Generic;
using UnityEngine;

namespace Sample.FlyWeight.Sample3
{
    public class EnemyFactory 
    {
        private Dictionary<string, IEnemy> _enemies = new Dictionary<string, IEnemy>();

        public EnemyFactory()
        {
            _enemies.Add("Slime", new WeakEnemy("スライム"));
            _enemies.Add("Gorem", new NormalEnemy("ゴーレム"));
            _enemies.Add("Orc", new NormalEnemy("オーク"));
            _enemies.Add("Dragon", new StrongEnemy("ドラゴン"));
        }

        public IEnemy GetEnemy(string name)
        {
            return _enemies[name];
        }
    }
}
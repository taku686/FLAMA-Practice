using UnityEngine;

namespace Sample.Iterator.Sample4
{
    public class EnemyGroup : Aggregate
    {
        private Enemy[] _enemies;
        private int _last = 0;

        public EnemyGroup(int maxSize)
        {
            _enemies = new Enemy[maxSize];
        }

        public void AddEnemy(Enemy enemy)
        {
            _enemies[_last] = enemy;
            _last++;
        }

        public int GetLength()
        {
            return _enemies.Length;
        }

        public Enemy GetEnemyAt(int index)
        {
            return _enemies[index];
        }

        public Iterator _iterator()
        {
            return new EnemyGroupIterator(this);
        }
    }
}
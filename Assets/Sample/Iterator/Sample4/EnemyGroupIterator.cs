using FORGE3D;
using UnityEngine;

namespace Sample.Iterator.Sample4
{
    public class EnemyGroupIterator : Iterator
    {
        private EnemyGroup _enemyGroup;
        private int _index;

        public EnemyGroupIterator(EnemyGroup enemyGroup)
        {
            _enemyGroup = enemyGroup;
            _index = 0;
        }

        public bool HasNext()
        {
            if (_index < _enemyGroup.GetLength()) return true;

            return false;
        }

        public object Next()
        {
            Enemy enemy = _enemyGroup.GetEnemyAt(_index);
            _index++;
            return enemy;
        }
    }
}
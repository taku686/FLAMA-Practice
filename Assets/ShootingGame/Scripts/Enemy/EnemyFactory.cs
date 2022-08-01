using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public class EnemyFactory : MonoBehaviour, IEnemyFactory
    {
        [SerializeField] private EnemyCore _enemyPrefab;

        public void Create()
        {
            var num = Random.Range(0, 2);
            GameObject enemyClone = Instantiate(_enemyPrefab.gameObject);
            switch (num)
            {
                case 0:
                    enemyClone.AddComponent<WeakEnemy>();
                    break;
                case 1:
                    enemyClone.AddComponent<NormalEnemy>();
                    break;
                case 2:
                    enemyClone.AddComponent<StrongEnemy>();
                    break;
            }
        }
    }
}

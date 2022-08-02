using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public class EnemyFactory : MonoBehaviour, IEnemyFactory
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform[] _enemySpawnpoints;

        public EnemyCore Create()
        {
            EnemyCore enemy = null;
            var spawnPoint = _enemySpawnpoints[Random.Range(0, _enemySpawnpoints.Length)];
            GameObject obj = Instantiate(_prefab, spawnPoint.position, _prefab.transform.rotation);
            var num = Random.Range(0, 3);
            Debug.Log("RandomNumber" + num);
            switch (num)
            {
                case 0:
                    enemy = obj.gameObject.AddComponent<WeakEnemy>();
                    enemy.Initialize();
                    break;
                case 1:
                    enemy = obj.gameObject.AddComponent<NormalEnemy>();
                    enemy.Initialize();
                    break;
                case 2:
                    enemy = obj.gameObject.AddComponent<NormalEnemy>();
                    enemy.Initialize();
                    break;
                default:
                    break;
            }

            if (enemy != null)
            {
                enemy.gameObject.AddComponent<EnemyPresenter>().Initialize();
            }

            return enemy;
        }
    }
}
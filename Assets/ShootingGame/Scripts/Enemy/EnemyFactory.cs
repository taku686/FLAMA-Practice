using System;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace ShootingGame.Scripts.Enemy
{
    public class EnemyFactory : MonoBehaviour, IEnemyFactory
    {
        [Inject(Id = "enemy")] private GameObject _prefab;

        private float _distanceToMainCamera;
        private Vector3 _min;
        private Vector3 _max;

        public void Initialize()
        {
            _distanceToMainCamera = Vector3.Distance(Vector3.zero, Camera.main.transform.position) * 0.9f;
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, _distanceToMainCamera));
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, _distanceToMainCamera));
        }


        public EnemyCore Create()
        {
            EnemyCore enemy = null;
            GameObject obj = Instantiate(_prefab, CreatePosition(), _prefab.transform.rotation);
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
                    enemy = obj.gameObject.AddComponent<StrongEnemy>();
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

        private Vector3 CreatePosition()
        {
            Vector3 pos = new Vector3(
                Random.Range((int)_min.x, (int)_max.x),
                0,
                _max.z + 1);
            //Debug.Log(pos);
            return pos;
        }
    }
}
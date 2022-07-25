using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Sample.Iterator.Sample4
{
    public class IteratorSample4 : MonoBehaviour
    {
        public Enemy[] _enemies;
        private EnemyGroup _enemyGroup;

        private void Start()
        {
            _enemyGroup = new EnemyGroup(_enemies.Length);
            Iterator it = _enemyGroup._iterator();
            for (int i = 0; i < _enemies.Length; i++)
            {
                _enemyGroup.AddEnemy(_enemies[i]);
            }

            while (it.HasNext())
            {
                var e = it.Next();
                GenerateEnemy((Enemy)e);
            }
        }

        private void GenerateEnemy(Enemy enemy)
        {
            GameObject g = null;
            switch (enemy.EnemyType)
            {
                case EnemyType.Weak:
                    g = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    enemy.Color = Color.red;
                    enemy.Name = "Weak";
                    break;
                case EnemyType.Normal:
                    g = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    enemy.Color = Color.green;
                    enemy.Name = "Normal";
                    break;
                case EnemyType.Strong:
                    g = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                    enemy.Color = Color.blue;
                    enemy.Name = "Strong";
                    break;
            }

            g.GetComponent<MeshRenderer>().material.color = enemy.Color;
            g.transform.position = new Vector3Int(Random.Range(-5, 5), Random.Range(-5, 5), 0);
        }
    }
}
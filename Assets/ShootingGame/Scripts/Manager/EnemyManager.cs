using System.Collections;
using System.Collections.Generic;
using ShootingGame.Scripts.Enemy;
using UnityEngine;
using UniRx;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    private readonly List<EnemyCore> _enemies = new List<EnemyCore>();
    private readonly CompositeDisposable _conpositDisposable = new CompositeDisposable();
    [SerializeField] private EnemyFactory _factory;

    public void ResetEnemies()
    {
        _conpositDisposable.Clear();

        foreach (var enemyCore in _enemies)
        {
            if (enemyCore != null) Destroy(enemyCore.gameObject);
        }

        _enemies.Clear();

        StopAllCoroutines();
        StartCoroutine(EnemySpawnCorutine());
    }

    private IEnumerator EnemySpawnCorutine()
    {
        while (true)
        {
            _enemies.Add(_factory.Create());
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{ 
    [SerializeField] private EnemyCore _prefab;
    [SerializeField] private Transform[] _enemySpawnpoints;
    private readonly List<EnemyCore> _enemies = new List<EnemyCore>();
    private readonly CompositeDisposable _conpositDisposable = new CompositeDisposable();

    public void ResetEnemies()
    {
        _conpositDisposable.Clear();

        foreach(var enemyCore in _enemies)
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
            var spawnPoint = _enemySpawnpoints[Random.Range(0, _enemySpawnpoints.Length)];
            var enemy = Instantiate(_prefab, spawnPoint.position, _prefab.transform.rotation);
            _enemies.Add(enemy);
            yield return new WaitForSeconds(Random.Range(2, 5));
        }
    }
}

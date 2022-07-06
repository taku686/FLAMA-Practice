using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public Enemy[] _enemies;
    private EnemyGroup _enemyGroup;
    private EnemyGroup _enemyGroup2;
    public GameObject enemyTag;

    private void Start()
    {
        _enemyGroup = new EnemyGroup(_enemies.Length);
        _enemyGroup2 = new EnemyGroup(_enemies.Length);
        Iterator it = _enemyGroup.iterator();
        for (int i = 0; i < _enemies.Length; i++)
        {
            _enemyGroup.AddEnemy(_enemies[i]);
        }

        while (it.HasNext())
        {
            var e = it.Next();
            GenerateEnemy((Enemy)e);
        }

        Iterator it2 = _enemyGroup2.iterator();
        for (int i = 0; i < _enemies.Length; i++)
        {
            _enemyGroup2.AddEnemy(_enemies[i]);
        }

        while (it2.HasNext())
        {
            var e = it2.Next();
            GenerateEnemy((Enemy)e);
        }
    }

    public void GenerateEnemy(Enemy enemy)
    {
        GameObject g = null;
        switch (enemy.getEnemyType())
        {
            case EnemyType.EnemyTypes.Cube:
                g = GameObject.CreatePrimitive(PrimitiveType.Cube);
                break;
            case EnemyType.EnemyTypes.Capsule:
                g = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                break;
            case EnemyType.EnemyTypes.Sphere:
                g = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                break;
        }

        g.transform.position = new Vector3Int(Random.Range(-5, 5), Random.Range(-5, 5), 0);
        Instantiate(enemyTag, g.transform);
        enemyTag.GetComponent<TextMesh>().text = enemy.getName() + "\nHP:" + enemy.getHP() + "\nMP:" + enemy.getMP();
    }
}
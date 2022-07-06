public class EnemyGroup : Aggregate
{
    private Enemy[] _enemies;
    private int last = 0;

    public EnemyGroup(int maxSize)
    {
        this._enemies = new Enemy[maxSize];
    }

    public void AddEnemy(Enemy enemy)
    {
        this._enemies[last] = enemy;
        last++;
    }

    public int GetLength()
    {
        return _enemies.Length;
    }

    public Enemy GetEnemyAt(int index)
    {
        return _enemies[index];
    }

    public Iterator iterator()
    {
        return new EnemyGroupIterator(this);
    }
}
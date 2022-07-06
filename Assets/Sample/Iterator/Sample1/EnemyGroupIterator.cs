public class EnemyGroupIterator : Iterator
{
    private EnemyGroup _enemyGroup;
    private int _index;

    public EnemyGroupIterator(EnemyGroup enemyGroup)
    {
        this._enemyGroup = enemyGroup;
        this._index = 0;
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
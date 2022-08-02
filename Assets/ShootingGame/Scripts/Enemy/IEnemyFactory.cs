using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public interface IEnemyFactory
    {
        EnemyCore Create();
    }
}
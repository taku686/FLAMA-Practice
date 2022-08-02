using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public interface IEnemyBehaviourBase
    {
        public string Name { get; }
        public void Move();
    }
}
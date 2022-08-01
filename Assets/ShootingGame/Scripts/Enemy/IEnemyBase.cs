using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public interface IEnemyBase
    {
        public string Name { get; set; }
        public void Move();
    }
}
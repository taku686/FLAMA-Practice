using System.Collections;
using System.Collections.Generic;
using DI.Sample2;
using UnityEngine;
using Zenject;

namespace DI.Sample3
{
    public class Enemy : IEnemy
    {
        private readonly Player _player;

        private readonly float _speed;

        public Enemy(float speed, Player player)
        {
            _player = player;
            _speed = speed;
        }

        public class Factory : PlaceholderFactory<float, Enemy>
        {
            
        }
    }
}
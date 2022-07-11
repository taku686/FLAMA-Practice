using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI.Sample2
{
    public class Enemy
    {
        private Player _player;

        public Enemy(Player player)
        {
            _player = player;
        }

        public class Factory : PlaceholderFactory<Enemy>
        {
            
        }
    }
}
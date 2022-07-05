using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  System;
using  Cysharp.Threading.Tasks;
using  UniRx;
using  Random = UnityEngine.Random;

namespace mvp3
{
    public class PlayerManager : MonoBehaviour
    {
        public IReactiveCollection<Player> Players => _players;

        private readonly ReactiveCollection<Player> _players = new ReactiveCollection<Player>();

        [SerializeField] private Player _playerPrefab;

        private async UniTaskVoid Start()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(1));
            _players.Add(CreatePlayer(1));
            
            await UniTask.Delay(TimeSpan.FromSeconds(1));
            _players.Add(CreatePlayer(2));
            
            await UniTask.Delay(TimeSpan.FromSeconds(1));
            _players.Add(CreatePlayer(3));
            
            await UniTask.Delay(TimeSpan.FromSeconds(1));
            _players.Add(CreatePlayer(4));
        }

        private Player CreatePlayer(int id)
        {
            var player = Instantiate(_playerPrefab, Vector3.right *Random.Range(1f, 2f), Quaternion.identity);
            player.name = $"Player{id}";
            return player;
        }
    }
}
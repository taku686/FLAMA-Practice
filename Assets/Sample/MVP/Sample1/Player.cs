using System;
using UnityEngine;
using UniRx;

namespace mvp
{
    public class Player : MonoBehaviour
    {
        public IReadOnlyReactiveProperty<int> Health => _health;
        public int _maxHealth = 100;
        private readonly IntReactiveProperty _health = new IntReactiveProperty(100);
            
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent<Enemy>(out var _))
            {
                _health.Value -= 10;
            }
        }

        private void OnDestroy()
        {
            _health.Dispose();
        }
    }
}
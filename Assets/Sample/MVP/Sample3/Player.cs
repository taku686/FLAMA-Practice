using System;
using mvp;
using UnityEngine;
using  UniRx;

namespace mvp3
{
    public class Player : MonoBehaviour
    {
        public  IReadOnlyReactiveProperty<int> Health=>_health;
        public readonly  int MaxHealth = 100;

        private readonly IntReactiveProperty _health = new IntReactiveProperty(100);
        // Start is called before the first frame update
        void Start()
        {
            _health.Value = MaxHealth;
        }

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
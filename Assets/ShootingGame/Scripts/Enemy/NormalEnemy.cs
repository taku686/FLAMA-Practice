using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ShootingGame.Scripts.Enemy
{
    public class NormalEnemy : EnemyCore, IEnemyBehaviourBase
    {
        private float _moveSpeedZ;
        private float _moveSpeedX;
        private string _name = "NormalEnemy";
        public string Name => _name;
        private Rigidbody _rigid;
        private Color _color = Color.green;

        public override void Initialize()
        {
            this.gameObject.name = _name;
            _moveSpeedZ = Random.Range(-4.0f, -8.0f);
            _moveSpeedX = Random.Range(1.0f, 4.0f);
            _rigid = GetComponent<Rigidbody>();
            foreach (var meshRenderer in GetComponentsInChildren<MeshRenderer>())
            {
                meshRenderer.material.color = _color;
            }

            base.Initialize();
        }

        private void FixedUpdate()
        {
            Move();
        }

        public void Move()
        {
            _rigid.velocity = new Vector3(_moveSpeedX * Mathf.Sin(Time.time), 0, _moveSpeedZ);
        }
    }
}
using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public class StrongEnemy : EnemyCore, IEnemyBehaviourBase
    {
        private float _moveSpeedZ;
        private string _name = "StrongEnemy";
        public string Name => _name;
        private Rigidbody _rigid;
        private Color _color = Color.blue;
        private Transform _player;
        private Vector3 _endDir = Vector3.zero;

        public override void Initialize()
        {
            _player = GameObject.FindGameObjectWithTag("Player").transform;
            this.gameObject.name = _name;
            _moveSpeedZ = Random.Range(-4.0f, -8.0f);
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
            Vector3 moveDir = (transform.position - _player.position).normalized;

            if (transform.position.z < _player.position.z + 5)
            {
                //transform.position += _endDir * _.z * Time.deltaTime;
                _rigid.velocity = _endDir * _moveSpeedZ;
            }
            else
            {
                //enemyTransform.position += moveDir.normalized * moveSpeed.z * Time.deltaTime;
                _rigid.velocity = moveDir * _moveSpeedZ;
                _endDir = moveDir.normalized;
            }
        }
    }
}
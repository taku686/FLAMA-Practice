using UnityEngine;

namespace ShootingGame.Scripts.Enemy
{
    public class WeakEnemy : EnemyCore, IEnemyBehaviourBase
    {
        private float _moveSpeedZ;

        //private float _moveSpeedX;
        private string _name = "WeakEnemy";
        public string Name => _name;
        private Rigidbody _rigid;
        private Color _color = Color.yellow;

        public override void Initialize()
        {
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
            _rigid.velocity = new Vector3(0, 0, _moveSpeedZ);
        }
    }
}
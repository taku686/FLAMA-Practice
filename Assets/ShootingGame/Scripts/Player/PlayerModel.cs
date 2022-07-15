using System;
using mvp;
using UnityEngine;
using UniRx;

public class PlayerModel : MonoBehaviour
{
    public readonly int MaxHP = 30;
    public readonly Vector3 _shotPosSetOff = new Vector3(0, 0, 3.0f);
    public IReadOnlyReactiveProperty<int> Health => _health;
    private readonly IntReactiveProperty _health = new IntReactiveProperty(30);
    public IReadOnlyReactiveProperty<Vector3> MoveDirection => _move;
    private readonly ReactiveProperty<Vector3> _move = new ReactiveProperty<Vector3>();
    [SerializeField] private PlayerShotManagement _shotManagement;
    private int _count;
    public string _cuurentBullettype;
    public Rigidbody _rigidbody;
    public float _moveSpeed = 3;
    private bool _IsDeath;

    private void Start()
    {
        _health.Value = MaxHP;
        _shotManagement.Initialize();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_IsDeath)
        {
            return;
        }
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<EnemyCore>(out var _))
        {
            _health.Value -= 10;
        }
    }

    private void OnDestroy()
    {
        _health.Dispose();
    }

    public void Shot()
    {
        _shotManagement.Shot(this);
    }

    public void ChangeBulletType()
    {
        _count++;
        if (_count % 3 == 0)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.NormalShot);
            _cuurentBullettype = "NormalShot";
        }
        else if (_count % 3 == 1)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.LaserShot);
            _cuurentBullettype = "LaserShot";
        }
        else if (_count % 3 == 2)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.DiffusionShot);
            _cuurentBullettype = "DiffusionShot";
        }
    }

    private void Move()
    {
        _move.SetValueAndForceNotify(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
    }

    public void Death()
    {
        _IsDeath = true;
        _health.Value = 30;
    }
}
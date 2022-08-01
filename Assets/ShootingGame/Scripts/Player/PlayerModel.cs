using System;
using mvp;
using UnityEngine;
using UniRx;

[RequireComponent(typeof(Rigidbody))]
public class PlayerModel : MonoBehaviour
{
    private Vector3 _startPosition;
    public readonly int MaxHP = 30;
    public readonly Vector3 ShotPosSetOff = new Vector3(0, 0, 3.0f);
    public IReadOnlyReactiveProperty<int> Health => _health;
    private readonly IntReactiveProperty _health = new IntReactiveProperty(30);
    public IReadOnlyReactiveProperty<Vector3> MoveDirection => _move;
    private readonly ReactiveProperty<Vector3> _move = new ReactiveProperty<Vector3>();
    [SerializeField] private PlayerShotManagement _shotManagement;
    private int _count;
    [HideInInspector] public string _currentBulletType;
    public Rigidbody _rigid;
    public float _moveSpeed = 3;
    private bool _IsDeath;

    public bool IsDeath
    {
        get => _IsDeath;
        set => _IsDeath = value;
    }

    private Vector3 _min;
    private Vector3 _max;
    private float _distanceToMainCamera;

    private void Start()
    {
        _startPosition = transform.position;
        _health.Value = MaxHP;
        _shotManagement.Initialize();
        _rigid = GetComponent<Rigidbody>();
        if (Camera.main != null)
        {
            _distanceToMainCamera = Vector3.Distance(Vector3.zero, Camera.main.transform.position) * 0.9f;
            _min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, _distanceToMainCamera));
            _max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 30 * 0.9f));
        }
    }

    private void Update()
    {
        if (_IsDeath)
        {
            return;
        }

        PLayerPositionClamp();
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
        _shotManagement._shot.Shot(_shotManagement._bullet, this);
    }

    public void ChangeBulletType()
    {
        _count++;
        if (_count % 3 == 0)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.NormalShot);
            _currentBulletType = "NormalShot";
        }
        else if (_count % 3 == 1)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.LaserShot);
            _currentBulletType = "LaserShot";
        }
        else if (_count % 3 == 2)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.DiffusionShot);
            _currentBulletType = "DiffusionShot";
        }
    }

    private void PLayerPositionClamp()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, _min.x, _max.x);
        pos.z = Mathf.Clamp(pos.z, _min.z, _max.z);

        transform.position = pos;
    }

    public void Death()
    {
        _IsDeath = true;
        _health.Value = 30;
        _rigid.velocity = Vector3.zero;
        transform.position = _startPosition;
        Debug.Log("Player死亡");
    }
}
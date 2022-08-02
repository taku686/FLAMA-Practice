using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace ShootingGame.Scripts.Manager
{
    public class InputEventProvider : MonoBehaviour
    {
        private const float ShotInterval = 0.5f;
        private const float ChangeBulletInterval = 1.0f;
        private const float RetryTimeSpan = 1f;
        public IObservable<Unit> OnShot => _onShotSubject;
        public IObservable<Unit> OnChangeBullet => _onChangeBulletSubject;
        public IObservable<Unit> OnRetryGame => _onRetryGameSubject;
        public IReadOnlyReactiveProperty<Vector3> MoveDirection => _moveDirection;

        private readonly Subject<Unit> _onShotSubject = new Subject<Unit>();
        private readonly Subject<Unit> _onChangeBulletSubject = new Subject<Unit>();
        private readonly Subject<Unit> _onRetryGameSubject = new Subject<Unit>();
        private readonly ReactiveProperty<Vector3> _moveDirection = new ReactiveProperty<Vector3>();

        private void Start()
        {
            _onShotSubject.AddTo(this);
            _onChangeBulletSubject.AddTo(this);
            _onRetryGameSubject.AddTo(this);
            this.UpdateAsObservable()
                .Where(_ => Input.GetKey(KeyCode.Space))
                .ThrottleFirst(TimeSpan.FromSeconds(ShotInterval))
                .Subscribe(_ => { _onShotSubject.OnNext(Unit.Default); }).AddTo(this);
            this.UpdateAsObservable()
                .Where(_ => Input.GetKey(KeyCode.S))
                .ThrottleFirst(TimeSpan.FromSeconds(ChangeBulletInterval))
                .Subscribe(_ => { _onChangeBulletSubject.OnNext(Unit.Default); }).AddTo(this);
            this.UpdateAsObservable()
                .Where(_ => Input.GetKey(KeyCode.R))
                .ThrottleFirst(TimeSpan.FromSeconds(RetryTimeSpan))
                .Subscribe(_ =>
                {
                    _onRetryGameSubject.OnNext(Unit.Default);
                    //Debug.Log("Input KeyCode R");
                }).AddTo(this);
        }

        private void Update()
        {
            _moveDirection.SetValueAndForceNotify(
                new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        }
    }
}
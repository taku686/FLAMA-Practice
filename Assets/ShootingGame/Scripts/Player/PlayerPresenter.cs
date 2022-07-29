using System;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.PlayerLoop;

public class PlayerPresenter : MonoBehaviour
{
    [SerializeField] private PlayerModel _model;
    [SerializeField] private PlayerView _view;
    [SerializeField] private UIView _uiView;

    private void Start()
    {
        HealthObserver();
        Shot();
        ChangeBulletType();
        _view.BulletTypeText.text = "NormalShot";
    }

    private void FixedUpdate()
    {
        if (_model.IsDeath)
        {
            _model._rigidbody.velocity = Vector3.zero;
            return;
        }

        var moveVector = GetMoveVector();
        _model._rigidbody.velocity = moveVector * _model._moveSpeed;
    }

    private Vector3 GetMoveVector()
    {
        var x = _model.MoveDirection.Value.x;
        var z = _model.MoveDirection.Value.z;
        return new Vector3(x, 0, z);
    }

    private void HealthObserver()
    {
        _model.Health
            .Where(x => x > 0 && !_model.IsDeath)
            .Subscribe(x =>
            {
                _view.SetSliderValue((float)x / _model.MaxHP);
                _view.SetHpText(x);
            }).AddTo(this);
        _model.Health
            .Where(x => x <= 0 && !_model.IsDeath)
            .Subscribe(x =>
            {
                _model.Death();
                _view.SetHpText(_model.MaxHP);
                _view.SetSliderValue(1);
                _uiView._gameOverView.SetActive(true);
            }).AddTo(this);
    }

    private void Shot()
    {
        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Space))
            .ThrottleFirst(TimeSpan.FromSeconds(0.5f))
            .Subscribe(_ => { _model.Shot(); });
    }

    private void ChangeBulletType()
    {
        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.S))
            .ThrottleFirst(TimeSpan.FromSeconds(1f))
            .Subscribe(_ =>
            {
                _model.ChangeBulletType();
                _view.BulletTypeText.text = _model._cuurentBullettype;
            });
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;
using ShootingGame.Scripts.Damage;
using Random = UnityEngine.Random;

public class EnemyCore : MonoBehaviour, IDamageApplicable
{
    [SerializeField] private int _maxHp = 2;
    [SerializeField] private int _score = 10;

    private ReactiveProperty<int> _hp;
    private readonly AsyncSubject<int> _onKilledAsyncSubject = new AsyncSubject<int>();
    public IObservable<int> OnKilledAsync => _onKilledAsyncSubject;
    

    public virtual void Initialize()
    {
        _hp = new ReactiveProperty<int>(_maxHp);
        _hp.AddTo(this);
        //_enemyMove = GetComponent<EnemyMove>();
        _hp.Where(x => x <= 0)
            .Take(1)
            .Subscribe(_ => OnDead())
            .AddTo(this);
    }

    private void OnDead()
    {
        _onKilledAsyncSubject.OnNext(_score);
        _onKilledAsyncSubject.OnCompleted();
        Destroy(gameObject);
    }

    public void ApplyDamage(in Damage damage)
    {
        _hp.Value -= damage.DamageValue;
    }

    private void OnDestroy()
    {
        _onKilledAsyncSubject.Dispose();
    }
}
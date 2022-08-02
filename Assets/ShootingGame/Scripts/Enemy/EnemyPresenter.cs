using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;
using UniRx;
using UnityEngine;

public class EnemyPresenter : MonoBehaviour
{
    private UIView _view;

    private EnemyCore _enemyCore;

    public void Initialize()
    {
        _enemyCore = GetComponent<EnemyCore>();
        _view = GameObject.FindGameObjectWithTag("Score").GetComponent<UIView>();
        _enemyCore.OnKilledAsync
            .Subscribe(x =>
            {
                _view._totalScore += x;
                _view._score.text = _view._totalScore.ToString();
            }).AddTo(this);
    }
}
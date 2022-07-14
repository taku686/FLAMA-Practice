using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;
using UniRx;
using UnityEngine;

public class EnemyPresenter : MonoBehaviour
{
    private UIView _view;

    [SerializeField] private EnemyCore _enemyCore;

    // Start is called before the first frame update
    void Start()
    {
        _view = GameObject.FindGameObjectWithTag("Score").GetComponent<UIView>();
        _enemyCore.OnKilledAsync
            .Subscribe(x =>
            {
                _view._totalScore += x;
                _view._score.text = _view._totalScore.ToString();
            }).AddTo(this);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
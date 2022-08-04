using System.Collections;
using System.Collections.Generic;
using ShootingGame.Scripts.Manager;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

public class GeneralManager : MonoBehaviour
{
    //[SerializeField] private EnemyManager _enemyManager;
    [Inject] private EnemyManager _enemyManager;
    [SerializeField] private UIView _uiView;
    [SerializeField] private InputEventProvider _inputEvent;
    private PlayerModel _playerModel;
    private bool _isRetry;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        _enemyManager.Initialize();
        _enemyManager.ResetEnemies();
        _playerModel = GameObject.FindWithTag("Player").GetComponent<PlayerModel>();
        _playerModel.Health
            .Where(x => x <= 0)
            .Subscribe(x =>
            {
                _isRetry = true;
                // Debug.Log("Health: " + x);
            }).AddTo(this);

        _inputEvent.OnRetryGame.Where(_ => _isRetry)
            .Subscribe(_ =>
            {
                Retry();
                // Debug.Log("Game Retry");
            }).AddTo(this);
    }

    private void Retry()
    {
        _uiView._score.text = 0.ToString();
        _uiView._gameOverView.SetActive(false);
        _enemyManager.ResetEnemies();
        _playerModel.IsDeath = false;
        _isRetry = false;
    }
}
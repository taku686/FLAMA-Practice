using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralManager : MonoBehaviour
{
    [SerializeField] private EnemyManager _enemyManager;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        _enemyManager.ResetEnemies();
    }
}

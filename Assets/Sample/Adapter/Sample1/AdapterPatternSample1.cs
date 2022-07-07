using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterPatternSample1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // そのままEnemyRobotをnewした場合
        EnemyRobot fredTheRobot = new EnemyRobot();
        IEnemyAttacker tank = new EnemyTank();
        // アダプターパターンを利用した場合
        IEnemyAttacker adapter = new EnemyRobotAdapter(fredTheRobot);

        Debug.Log("--------fredTheRobot--------");
        fredTheRobot.ReactToHuman("Hans");
        fredTheRobot.WalkForward();

        Debug.Log("--------tank--------");
        tank.AssignDriver("Frank");
        tank.DriveForward();
        tank.FireWeapon();

        Debug.Log("--------adapter--------");
        adapter.AssignDriver("Mark");
        adapter.DriveForward();
        adapter.FireWeapon();
    }
}
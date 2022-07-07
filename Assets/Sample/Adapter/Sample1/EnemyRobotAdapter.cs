using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobotAdapter : IEnemyAttacker
{
    private readonly EnemyRobot _robot;
    
    public EnemyRobotAdapter(EnemyRobot robot)
    {
        _robot = robot;
    }
    
    public void FireWeapon()
    {
        _robot.SmashWithHands();
    }

    public void DriveForward()
    {
        _robot.WalkForward();
    }

    public void AssignDriver(string driver)
    {
        _robot.ReactToHuman(driver);
    }
}
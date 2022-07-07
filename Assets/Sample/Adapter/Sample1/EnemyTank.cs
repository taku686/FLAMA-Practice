using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  Random = UnityEngine.Random;

public class EnemyTank : IEnemyAttacker
{
    public void FireWeapon()
    {
        int attackDamage = Random.Range(1, 10);
        Debug.Log($"Enemy Tank does {attackDamage} damage");
    }

    public void DriveForward()
    {
        int movement = Random.Range(1, 5);
        Debug.Log("Enemy Tank moves " + movement + " spaces");
    }

    public void AssignDriver(string driver)
    {
        Debug.Log(driver + " is driving the tank");
    }
}
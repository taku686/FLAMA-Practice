using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobot 
{
    public void SmashWithHands()
    {
        int attackDamage = Random.Range(1, 10);
        Debug.Log("Robot causes " + attackDamage + " damage with it hands");
    }

    public void WalkForward()
    {
        int movement = Random.Range(1, 3);
        Debug.Log("Robot walks " + movement + " spaces");
    }

    public void ReactToHuman(string driverName)
    {
        Debug.Log("Robot tramps on " + driverName);
    }
}

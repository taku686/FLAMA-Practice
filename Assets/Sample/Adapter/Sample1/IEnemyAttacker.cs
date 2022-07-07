using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyAttacker
{
    void FireWeapon();
    void DriveForward();
    void AssignDriver(string driver);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var knight = new Knight();
        var buffKnight = new AttackUpDecorator(knight);

        Debug.Log($"knightの攻撃力{knight.Attack}");
        Debug.Log($"buffKnightの攻撃力{buffKnight.Attack}");
    }
}
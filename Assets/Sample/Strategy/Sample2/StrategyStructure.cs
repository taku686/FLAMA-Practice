using System.Collections;
using System.Collections.Generic;
using Sample.Strategy.Sample2;
using UnityEngine;

public class StrategyStructure : MonoBehaviour
{
    private Monster _monster;
    // Start is called before the first frame update
    void Start()
    {
        _monster = new Monster("ピカチュウ");
        _monster.Skill1 = new Hikkaki();
        _monster.Skill2 = new Hinoko();
        
        _monster.Attack(_monster.Skill1);
        _monster.Attack(_monster.Skill2);

        _monster.Skill2 = new PoisonBom();
        _monster.Attack(_monster.Skill2);
    }
}

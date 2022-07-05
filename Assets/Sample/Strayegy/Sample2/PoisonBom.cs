using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonBom : Skill
{
    public PoisonBom()
    {
        this.damage = 90;
        this.skill_name = "毒爆弾";
        this.skill_type = "毒";
    }

    public override void SkillEffect()
    {
        Debug.Log("相手を毒状態にする");
    }
}

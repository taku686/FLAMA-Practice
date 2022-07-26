using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinoko : Skill
{
    public Hinoko()
    {
        this.damage = 40;
        this.skill_name = "火の粉";
        this.skill_type = "炎";
    }
    public override void SkillEffect()
    {
        Debug.Log("相手を火傷状態にする");
    }
}

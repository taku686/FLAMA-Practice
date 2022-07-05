using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hikkaki : Skill
{
    public Hikkaki()
    {
        this.damage = 30;
        this.skill_name = "ひっかく";
        this.skill_type = "ノーマル";
    }

    public override void SkillEffect()
    {
        Debug.Log("技効果なし");
    }
}
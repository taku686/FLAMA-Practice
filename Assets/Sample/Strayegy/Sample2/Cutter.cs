using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : Skill
{
   public Cutter()
   {
      this.damage = 60;
      this.skill_name = "カッター";
      this.skill_type = "草";
   }
   public override void SkillEffect()
   {
      Debug.Log("クリティカル率2倍");
   }
}

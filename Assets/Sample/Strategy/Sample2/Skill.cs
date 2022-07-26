using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
   public abstract void SkillEffect();

   public int damage;
   public string skill_name;
   public string skill_type;
}

using UnityEngine;

namespace Sample.Strategy.Sample2
{
    public class Monster : MonoBehaviour
    {
        private Skill _skill1;

        private Skill _skill2;

        private readonly string name;

        public Monster(string name)
        {
            this.name = name;
        }

        public Skill Skill1
        {
            get => this._skill1;
            set => this._skill1 = value;
        }

        public Skill Skill2
        {
            get => this._skill2;
            set => this._skill2 = value;
        }

        public void Attack(Skill skill)
        {
            Debug.Log(this.name + "の攻撃！　" + skill.damage + " ダメージ！");
            //攻撃後の効果
            skill.SkillEffect();
        }
    }
}
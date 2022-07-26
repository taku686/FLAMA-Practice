using UnityEngine;

namespace Sample.Strategy.Sample4
{
    public class Player 
    {
        private IAttack _attack;

        public Player(IAttack attack)
        {
            _attack = attack;
        }

        public void Attack()
        {
            _attack.Attack();
        }

        public void SetAttack(IAttack attack)
        {
            _attack = attack;
        }
    }
}
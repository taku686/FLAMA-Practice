using System;
using UnityEngine;

namespace Sample.Facade.Sample3
{
    public class PlayerAttackFacade 
    {
        private readonly PlayerAttack _playerAttack;
        private readonly AttackEffect _attackEffect;
        private readonly AttackAnimation _attackAnimation;

        public PlayerAttackFacade()
        {
            _playerAttack = new PlayerAttack();
            _attackEffect = new AttackEffect();
            _attackAnimation = new AttackAnimation();
        }

        public void Attack()
        {
            _playerAttack.Attack();
            _attackEffect.Attack();
            _attackAnimation.Attack();
        }
    }
}
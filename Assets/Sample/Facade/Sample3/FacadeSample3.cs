using System;
using UnityEngine;

namespace Sample.Facade.Sample3
{
    public class FacadeSample3 : MonoBehaviour
    {
        private void Start()
        {
            var playerAttack = new PlayerAttackFacade();
            playerAttack.Attack();
        }
    }
}
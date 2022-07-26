using System;
using UnityEngine;

namespace Sample.Strategy.Sample4
{
    public class StrategySample4 : MonoBehaviour
    {
        private void Start()
        {
            IAttack slash = new Slash();
            IAttack magic = new Magic();
            IAttack blow = new Blow();

            Player player = new Player(slash);

            player.Attack();
            player.Attack();
            player.Attack();
            player.SetAttack(magic);
            player.Attack();
            player.SetAttack(blow);
            player.Attack();
        }
    }
}
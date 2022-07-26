using System;
using UnityEngine;

namespace Sample.FlyWeight.Sample3
{
    public class FlyweightSample3 : MonoBehaviour
    {
        private void Start()
        {
            var enemyFactory = new EnemyFactory();

            var slime = enemyFactory.GetEnemy("Slime");
            var gorem = enemyFactory.GetEnemy("Gorem");
            var orc = enemyFactory.GetEnemy("Orc");
            var dragon = enemyFactory.GetEnemy("Dragon");

            slime.Attack();
            gorem.Attack();
            orc.Attack();
            dragon.Attack();
        }
    }
}
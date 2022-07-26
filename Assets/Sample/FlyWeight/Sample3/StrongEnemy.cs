using UnityEngine;

namespace Sample.FlyWeight.Sample3
{
    public class StrongEnemy : IEnemy
    {
        private string _name;

        public StrongEnemy(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public void Attack()
        {
            Debug.Log(_name + "の攻撃!!");
        }
    }
}
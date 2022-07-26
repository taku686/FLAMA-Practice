using UnityEngine;

namespace Sample.FlyWeight.Sample3
{
    public class WeakEnemy : IEnemy
    {
        private string _name;

        public WeakEnemy(string name)
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
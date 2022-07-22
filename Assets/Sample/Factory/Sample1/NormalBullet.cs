using UnityEngine;

namespace Sample.Factory.Sample1
{
    public class NormalBullet : BaseBullet
    {
        private string _name;
        private int _id;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public NormalBullet(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public void Shot()
        {
            Debug.Log(_id + ": " + _name + "発射！！");
        }
    }
}
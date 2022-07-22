using UnityEngine;

namespace Sample.Factory.Sample1
{
    public  interface BaseBullet
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public  void Shot();
    }
}
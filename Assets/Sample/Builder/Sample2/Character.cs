using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

namespace Sample.Builder.Sample2
{
    public class Character 
    {
        private string _name;
        private Dictionary<string, int> _status = new Dictionary<string, int>();

        public Character(string name)
        {
            _name = name;
        }

        public int this[string key]
        {
            get => _status[key];
            set => _status[key] = value;
        }

        public void Show()
        {
            Debug.Log("\n---------------------------");
            Debug.Log("Monster Name : " + _name);
            Debug.Log(" Attack : " + _status["attack"]);
            Debug.Log(" Defense : " + _status["defense"]);
            Debug.Log(" Hp: " + _status["hp"]);
            Debug.Log(" Mp : " + _status["mp"]);
        }
    }
}
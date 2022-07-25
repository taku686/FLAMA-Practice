using UnityEngine;

namespace Sample.Iterator.Sample4
{
    [System.Serializable]
    public class Enemy
    {
        private string _name;
        private Color _color;
        [SerializeField]
        private EnemyType _enemyType;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Color Color
        {
            get => _color;
            set => _color = value;
        }

        public EnemyType EnemyType
        {
            get => _enemyType;
            set => _enemyType = value;
        }

        public Enemy(string name, Color color, EnemyType enemyType)
        {
            _name = name;
            _color = color;
            _enemyType = enemyType;
        }
    }

    public enum EnemyType
    {
        Weak,
        Normal,
        Strong
    }
}
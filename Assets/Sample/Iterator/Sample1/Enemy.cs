using UnityEngine;

[System.Serializable]
public class Enemy
{
   [SerializeField] private string _name;
   [SerializeField] private int _HP;
   [SerializeField] private int _MP;
   [SerializeField] private EnemyType.EnemyTypes _enemyType;

   public Enemy(string name, int HP, int MP, EnemyType.EnemyTypes enemyType)
   {
      _name = name;
      _HP = HP;
      _MP = MP;
      _enemyType = enemyType;
   }

   public string getName()
   {
      return _name;
   }

   public int getHP()
   {
      return _HP;
   }

   public int getMP()
   {
      return _MP;
   }

   public EnemyType.EnemyTypes getEnemyType()
   {
      return _enemyType;
   }
}

using UnityEngine;

namespace Sample.Builder.Sample2
{
    public class EnemyGenerator 
    {
        public void Generate(CharacterBuilder characterBuilder)
        {
            characterBuilder.BuildCharacter();
        }
    }
}
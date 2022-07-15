using UnityEngine;

namespace Sample.Builder.Sample2
{
    public abstract class CharacterBuilder
    {
        protected Character _character;

        public Character Character => _character;

        public abstract void BuildCharacter();
    }
}
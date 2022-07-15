using UnityEngine;

namespace Sample.Builder.Sample2
{
    public class Orc : CharacterBuilder
    {
        public Orc()
        {
            _character = new Character("Orc");
        }

        public override void BuildCharacter()
        {
            _character["attack"] = 5;
            _character["defense"] = 3;
            _character["hp"] = 10;
            _character["mp"] = 0;
        }
    }
}
using UnityEngine;

namespace Sample.Builder.Sample2
{
    public class Slime : CharacterBuilder
    {
        public Slime()
        {
            _character = new Character("Slime");
        }

        public override void BuildCharacter()
        {
            _character["attack"] = 1;
            _character["defense"] = 1;
            _character["hp"] = 5;
            _character["mp"] = 3;
        }
    }
}
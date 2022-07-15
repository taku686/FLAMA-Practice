using UnityEngine;

namespace Sample.Builder.Sample2
{
    public class Dragon : CharacterBuilder
    {
        public Dragon()
        {
            _character = new Character("Dragon");
        }

        public override void BuildCharacter()
        {
            _character["attack"] = 15;
            _character["defense"] = 10;
            _character["hp"] = 30;
            _character["mp"] = 25;
        }
    }
}
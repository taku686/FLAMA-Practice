using System;
using UnityEngine;
using Zenject;

namespace Sample.Builder.Sample2
{
    public class BuildSample2 : MonoBehaviour
    {
        private void Start()
        {
            CharacterBuilder builder;

            EnemyGenerator generator = new EnemyGenerator();

            builder = new Slime();
            generator.Generate(builder);
            builder.Character.Show();

            builder = new Orc();
            generator.Generate(builder);
            builder.Character.Show();

            builder = new Dragon();
            generator.Generate(builder);
            builder.Character.Show();
        }
    }
}
using UnityEngine;
using Zenject;

namespace Sample.DI.Sample7
{
    public class ExampleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Example>().AsTransient();
        }
    }
}
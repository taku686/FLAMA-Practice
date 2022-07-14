using UnityEngine;
using Zenject;

namespace Sample.DI.Sample8
{
    public class SampleInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _prefab;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<DISample8>()
                .AsSingle();
          
            
        }
    }
}
using System;
using UnityEngine;
using Zenject;

namespace Sample.DI.Sample8
{
    public class DynamicGenerator : MonoBehaviour
    {
        [Inject] private DiContainer _container;
        [SerializeField] private GameObject _prefab;

        private void Start()
        {
            var obj = Instantiate(_prefab);

            _container.InstantiateComponent<Mover>(obj);
        }
    }
}
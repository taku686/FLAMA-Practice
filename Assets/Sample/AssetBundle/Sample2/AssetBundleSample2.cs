using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Sample.AssetBundle.Sample2
{
    public class AssetBundleSample2 : MonoBehaviour
    {
        private GameObject spawnedGameObject;

        private async void Start()
        {
            // Addressables.InstantiateAsyncでプレハブをインスタンス化する
            AsyncOperationHandle<GameObject> handle = Addressables.InstantiateAsync("Assets/Sample/AssetBundle/Prefab/Cube.prefab");

            // .Taskでインスタンス化完了までawaitできる
            spawnedGameObject = await handle.Task;

            spawnedGameObject.name = "Spawned Game Object";
        }

        private void OnDestroy()
        {
            // 使い終わったらインスタンスをリリースする
            Addressables.ReleaseInstance(spawnedGameObject);
        }
    }
}
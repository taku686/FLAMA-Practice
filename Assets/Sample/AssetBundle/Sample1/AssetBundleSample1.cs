using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Sample.AssetBundle.Sample1
{
    public class AssetBundleSample1 : MonoBehaviour
    {
        private AsyncOperationHandle<GameObject> prefabHandle;
        private GameObject spawnedGameObject;

        private async void Start()
        {
            // Addressables.LoadAssetAsyncで読み込む
            prefabHandle = Addressables.LoadAssetAsync<GameObject>("Assets/Sample/AssetBundle/Prefab/Cube.prefab");

            // .Taskで読み込み完了までawaitできる
            GameObject prefab = await prefabHandle.Task;

            // 読み込んだプレハブをインスタンス化する
            spawnedGameObject = Instantiate(prefab);
            spawnedGameObject.name = "Spawned Game Object";
        }

        private void OnDestroy()
        {
            // インスタンス化したGameObjectを破棄する
            Destroy(spawnedGameObject);

            // 使い終わったらhandleをリリースする
            Addressables.Release(prefabHandle);
        }
    }
}
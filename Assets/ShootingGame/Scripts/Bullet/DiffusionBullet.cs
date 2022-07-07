using UnityEngine;

public class DiffusionBullet : IBulletBase
{
    private GameObject _prefab;
    public string Name => "DiffusionBullet";

    public GameObject prefab
    {
        get => _prefab;
        set => _prefab = value;
    }
    
    
}

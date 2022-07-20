using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffusionShot :MonoBehaviour, IShot
{
    private const float _force = 20;
    private const float _angle = 30f;
    private const float _count = 5;
 
    public void Shot(IBulletBase bullet, PlayerModel player)
    {
        for(int i = 0; i < _count; i++)
        {
            GameObject bulletClone = Instantiate(bullet.prefab);
            bulletClone.transform.position = player.transform.position + player._shotPosSetOff;
            bulletClone.transform.eulerAngles = new Vector3(0, -(_angle / 2f) + _angle / (_count - 1f) * i, 0);
            bulletClone.GetComponent<Rigidbody>().AddForce(bulletClone.transform.forward * _force, ForceMode.Impulse);
            var selfDestroy = bulletClone.AddComponent<SelfDestroy>();
            selfDestroy.SetDamage(new Damage(bullet.Attack));
            Debug.Log("DiffusionShot"+"Attack"+ bullet.Attack);
        }
    }
}

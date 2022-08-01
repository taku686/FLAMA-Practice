using System.Collections;
using System.Collections.Generic;
using ShootingGame.Scripts.Damage;
using UnityEngine;

public class NormalShot : MonoBehaviour,IShot
{
    private const float _force = 30;

    public void Shot(IBulletBase bullet, PlayerModel player)
    {
        GameObject bulletClone = Instantiate(bullet.prefab);
        bulletClone.transform.position = player.transform.position + player.ShotPosSetOff;
        bulletClone.GetComponent<Rigidbody>().AddForce(bulletClone.transform.forward * _force, ForceMode.Impulse);
        var selfDestroy = bulletClone.AddComponent<SelfDestroy>();
        selfDestroy.SetDamage(new Damage(bullet.Attack));
        Debug.Log("NormalShot"+"Attack"+ bullet.Attack);
    }
}

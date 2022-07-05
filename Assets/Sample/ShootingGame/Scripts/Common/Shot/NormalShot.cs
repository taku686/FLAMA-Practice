using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalShot : MonoBehaviour,IShot
{
    private const float _force = 30;

    public void Shot(GameObject bullet, PlayerModel player)
    {
        GameObject bulletClone = Instantiate(bullet);
        bulletClone.transform.position = player.transform.position + player._shotPosSetOff;
        bulletClone.GetComponent<Rigidbody>().AddForce(bulletClone.transform.forward * _force, ForceMode.Impulse);
        bulletClone.AddComponent<SelfDestroy>();
        Debug.Log("NormalShot");
    }
}

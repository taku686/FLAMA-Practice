using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private Damage _damage;

    private void Start()
    {
        _damage = new Damage(1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<IDamageApplicable>(out IDamageApplicable applyDamage))
        {
            applyDamage.ApplyDamage(_damage);
            Destroy((this.gameObject));
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
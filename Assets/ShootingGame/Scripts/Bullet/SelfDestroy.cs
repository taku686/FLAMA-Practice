using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private Damage _damage;

    public void SetDamage(Damage damage)
    {
        _damage = damage;
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
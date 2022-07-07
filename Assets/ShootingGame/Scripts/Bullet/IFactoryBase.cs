using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IFactoryBase : MonoBehaviour
{
    protected abstract IBulletBase MakeBullet(BulletType.BulletTypes type);

    public IBulletBase GetItem(BulletType.BulletTypes type)
    {
        return MakeBullet(type);
    }
}

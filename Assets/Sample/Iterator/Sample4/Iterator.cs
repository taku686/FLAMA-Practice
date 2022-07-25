using UnityEngine;

namespace Sample.Iterator.Sample4
{
    public interface Iterator
    {
        bool HasNext();
        System.Object Next();
    }
}
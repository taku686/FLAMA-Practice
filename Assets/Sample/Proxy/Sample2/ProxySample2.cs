using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proxy.Sample2
{
    public class ProxySample2 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ISpeaker proxy = new JapaneseSpeaker();
            Debug.Log(proxy.Hello());
            Debug.Log(proxy.Chat());
            Debug.Log(proxy.Bye());
        }
    }
}
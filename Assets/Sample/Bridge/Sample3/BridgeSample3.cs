using System;
using UnityEngine;

namespace Sample.Bridge.Sample3
{
    public class BridgeSample3 : MonoBehaviour
    {
        private void Start()
        {
            RemoteButton tv = new TVRemoteMute(new TVDevice(1, 200));
            RemoteButton tv2 = new TVRemotePause(new TVDevice(1, 200));

            Debug.Log("Test TV with Mute");
            tv.ButtonFivePressed();
            tv.ButtonSixPressed();
            tv.ButtonNinePressed();

            Debug.Log("Test TV with Pause");
            tv2.ButtonFivePressed();
            tv2.ButtonSixPressed();
            tv2.ButtonNinePressed();
        }
    }
}
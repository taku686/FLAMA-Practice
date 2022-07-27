using UnityEngine;

namespace Sample.Bridge.Sample3
{
    public class TVRemotePause : RemoteButton
    {
        public TVRemotePause(EntertainmentDevice device) : base(device)
        {
        }

        public override void ButtonNinePressed()
        {
            Debug.Log("TV was paused.");
        }
    }
}
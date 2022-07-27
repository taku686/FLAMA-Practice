using UnityEngine;

namespace Sample.Bridge.Sample3
{
    public class TVRemoteMute : RemoteButton
    {
        public TVRemoteMute(EntertainmentDevice device) : base(device)
        {
        }

        public override void ButtonNinePressed()
        {
            Debug.Log("TV was muted.");
        }
    }
}
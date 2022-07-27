using UnityEngine;

namespace Sample.Bridge.Sample3
{
    public class TVDevice : EntertainmentDevice
    {
        public TVDevice(int newDeviceState, int newMaxSetting)
        {
            _deviceState = newDeviceState;
            _maxSetting = newMaxSetting;
        }
        
        public override void ButtonFivePressed()
        {
            Debug.Log("Channel up");
            _deviceState++;
        }

        public override void ButtonSixPressed()
        {
            Debug.Log("Channel down");
            _deviceState--;
        }
    }
}
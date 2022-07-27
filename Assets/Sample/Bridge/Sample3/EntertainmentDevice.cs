using UnityEngine;

namespace Sample.Bridge.Sample3
{
    public abstract class EntertainmentDevice
    {
        public int _deviceState;
        public int _maxSetting;
        public int _volumeLevel = 0;

        public abstract void ButtonFivePressed();
        public abstract void ButtonSixPressed();

        public void DeviceFeedback()
        {
            if (_deviceState > _maxSetting || _deviceState < 0)
            {
                _deviceState = 0;
            }

            Debug.Log("On " + _deviceState);
        }

        public void ButtonSevenPressed()
        {
            _volumeLevel++;
            Debug.Log("Volume at:" + _volumeLevel);
        }

        public void ButtonEightPressed()
        {
            _volumeLevel--;
            Debug.Log("Volume at: " + _volumeLevel);
        }
    }
}
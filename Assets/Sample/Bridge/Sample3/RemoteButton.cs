using UnityEngine;

namespace Sample.Bridge.Sample3
{
    public abstract class RemoteButton
    {
        private EntertainmentDevice _device;

        public RemoteButton(EntertainmentDevice device)
        {
            _device = device;
        }

        public void ButtonFivePressed()
        {
            _device.ButtonFivePressed();
        }

        public void ButtonSixPressed()
        {
            _device.ButtonSixPressed();
        }

        public void DeviceFeedback()
        {
            _device.DeviceFeedback();
        }

        public abstract void ButtonNinePressed();
    }
}
using Bridge.Devices.Abstractions;

namespace Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            Device.SetVolume(0);
        }
    }
}
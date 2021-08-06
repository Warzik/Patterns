using Bridge.Devices.Abstractions;
using System;

namespace Bridge
{
    public class RemoteControl
    {
        protected IDevice Device { get; set; }

        public RemoteControl(IDevice device)
        {
            Device = device;
        }

        public void TogglePower()
        {
            if (Device.IsEnable())
            {
                Device.Disable();
            }
            else
            {
                Device.Enable();
            }
        }

        public void VolumeDown()
        {
            Device.SetVolume(Device.GetVolume() - 10);
        }

        public void VolumeUp() 
        {
            Device.SetVolume(Device.GetVolume() + 10);
        }

        public void ChannelDown()
        {
            Device.SetChannel(Device.GetChannel() - 1);
        }  
        
        public void ChannelUp()
        {
            Device.SetChannel(Device.GetChannel() + 1);
        }
    }
}
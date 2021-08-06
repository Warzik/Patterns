using Bridge.Devices.Abstractions;
using System;

namespace Bridge.Devices
{
    public class Radio : IDevice
    {
        public void Disable()
        {
            throw new NotImplementedException();
        }

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public int GetChannel()
        {
            throw new NotImplementedException();
        }

        public int GetVolume()
        {
            throw new NotImplementedException();
        }

        public bool IsEnable()
        {
            throw new NotImplementedException();
        }

        public void SetChannel(int channel)
        {
            throw new NotImplementedException();
        }

        public void SetVolume(int volume)
        {
            throw new NotImplementedException();
        }
    }
}
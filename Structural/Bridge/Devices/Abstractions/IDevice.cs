namespace Bridge.Devices.Abstractions
{
    public interface IDevice
    {
        public bool IsEnable();

        public void Enable();

        public void Disable();

        public int GetVolume();

        public void SetVolume(int volume);
        public int GetChannel();
        public void SetChannel(int channel);
    }
}
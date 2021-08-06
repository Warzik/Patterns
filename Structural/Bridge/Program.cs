using Bridge.Devices;

namespace Bridge
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var tv = new Tv();
            var remote = new RemoteControl(tv);
            remote.TogglePower();

            var radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
            ((AdvancedRemoteControl)remote).Mute();
        }
    }
}
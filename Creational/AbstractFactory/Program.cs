using AbstractFactory.Gui;
using AbstractFactory.Gui.Abstractions;
using System;

namespace AbstractFactory
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var gui = InitializeGui(Environment.OSVersion);

            var button = gui.CreateButton();
            var checkbox = gui.CreateCheckbox();

            button.OnClick(EventArgs.Empty);
            checkbox.SynchronizeStateWithButton(button);
        }

        private static IGuiFactory InitializeGui(OperatingSystem operatingSystem) =>
             operatingSystem.Platform switch
             {
                 PlatformID.Win32S or PlatformID.Win32Windows or PlatformID.Win32NT => new WinGuiFactory(),
                 PlatformID.MacOSX => new MacGuiFactory(),
                 _ => throw new Exception("Error! Unknown operating system.")
             };
    }
}

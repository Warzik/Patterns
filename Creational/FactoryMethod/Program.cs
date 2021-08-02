using FactoryMethod.Dialogs;
using FactoryMethod.Dialogs.Abstractions;
using System;

namespace FactoryMethod
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var dialog = InitializeDialog(Environment.OSVersion);

            dialog.Render();
        }

        private static Dialog InitializeDialog(OperatingSystem operatingSystem) =>
             operatingSystem.Platform switch
             {
                 PlatformID.Win32S or PlatformID.Win32Windows or PlatformID.Win32NT => new WindowsDialog(),
                 PlatformID.MacOSX => new MacDialog(),
                 _ => throw new Exception("Error! Unknown operating system.")
             };
    }
}

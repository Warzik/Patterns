using FactoryMethod.Buttons.Abstractions;
using System;

namespace FactoryMethod.Buttons
{
    public class WindowsButton : IButton
    {
        public void OnClick(EventArgs e)
        {
            Console.WriteLine(nameof(WindowsButton) + " is clicked.");
        }

        public void Render()
        {
            Console.WriteLine(nameof(WindowsButton) + " is rendering.");
        }
    }
}
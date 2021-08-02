using AbstractFactory.Buttons.Abstractions;
using System;

namespace AbstractFactory.Buttons
{
    public class WinButton : IButton
    {
        public void OnClick(EventArgs e)
        {
            Console.WriteLine(nameof(WinButton) + " is clicked.");
        }
    }
}
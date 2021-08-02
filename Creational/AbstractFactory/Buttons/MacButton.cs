using AbstractFactory.Buttons.Abstractions;
using System;

namespace AbstractFactory.Buttons
{
    public class MacButton : IButton
    {
        public void OnClick(EventArgs e)
        {
            Console.WriteLine(nameof(MacButton) + " is clicked.");
        }
    }
}
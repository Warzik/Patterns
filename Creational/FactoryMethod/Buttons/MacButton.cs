using FactoryMethod.Buttons.Abstractions;
using System;

namespace FactoryMethod.Buttons
{
    public class MacButton : IButton
    {
        public void OnClick(EventArgs e)
        {
            Console.WriteLine(nameof(MacButton) + " is clicked.");
        }

        public void Render()
        {
            Console.WriteLine(nameof(MacButton) + " is rendering.");
        }
    }
}
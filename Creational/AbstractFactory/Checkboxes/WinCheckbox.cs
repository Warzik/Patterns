using AbstractFactory.Buttons.Abstractions;
using AbstractFactory.Checkboxes.Abstractions;

namespace AbstractFactory.Checkboxes
{
    public class WinCheckbox : ICheckbox
    {
        public void SynchronizeStateWithButton(IButton button)
        {
            System.Console.WriteLine("Synchronize Windows button");
        }
    }
}
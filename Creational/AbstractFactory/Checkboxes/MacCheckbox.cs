using AbstractFactory.Buttons.Abstractions;
using AbstractFactory.Checkboxes.Abstractions;

namespace AbstractFactory.Checkboxes
{
    public class MacCheckbox : ICheckbox
    {
        public void SynchronizeStateWithButton(IButton button)
        {
            System.Console.WriteLine("Synchronize Mac button");
        }
    }
}
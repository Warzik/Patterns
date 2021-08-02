using AbstractFactory.Buttons;
using AbstractFactory.Buttons.Abstractions;
using AbstractFactory.Checkboxes;
using AbstractFactory.Checkboxes.Abstractions;
using AbstractFactory.Gui.Abstractions;

namespace AbstractFactory.Gui
{
    public class WinGuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
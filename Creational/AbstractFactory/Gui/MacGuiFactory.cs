using AbstractFactory.Buttons;
using AbstractFactory.Buttons.Abstractions;
using AbstractFactory.Checkboxes;
using AbstractFactory.Checkboxes.Abstractions;
using AbstractFactory.Gui.Abstractions;

namespace AbstractFactory.Gui
{
    public class MacGuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
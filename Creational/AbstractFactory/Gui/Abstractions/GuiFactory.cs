using AbstractFactory.Buttons.Abstractions;
using AbstractFactory.Checkboxes.Abstractions;

namespace AbstractFactory.Gui.Abstractions
{
    public interface IGuiFactory
    {
        ICheckbox CreateCheckbox();
        IButton CreateButton();
    }
}
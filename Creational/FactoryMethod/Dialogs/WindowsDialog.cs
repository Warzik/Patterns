using FactoryMethod.Buttons;
using FactoryMethod.Buttons.Abstractions;
using FactoryMethod.Dialogs.Abstractions;

namespace FactoryMethod.Dialogs
{
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
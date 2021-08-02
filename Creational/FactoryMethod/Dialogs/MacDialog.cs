using FactoryMethod.Buttons;
using FactoryMethod.Buttons.Abstractions;
using FactoryMethod.Dialogs.Abstractions;

namespace FactoryMethod.Dialogs
{
    public class MacDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new MacButton();
        }
    }
}
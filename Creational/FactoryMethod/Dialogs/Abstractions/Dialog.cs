using FactoryMethod.Buttons.Abstractions;
using System;

namespace FactoryMethod.Dialogs.Abstractions
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public void Render()
        {
            var okButton = CreateButton();
            okButton.Render();
            okButton.OnClick(EventArgs.Empty);
        }
    }
}
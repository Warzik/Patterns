using System;

namespace FactoryMethod.Buttons.Abstractions
{
    public interface IButton
    {
        void Render();

        void OnClick(EventArgs e);
    }
}
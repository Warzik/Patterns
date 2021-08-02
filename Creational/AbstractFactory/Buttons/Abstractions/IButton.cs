using System;

namespace AbstractFactory.Buttons.Abstractions
{
    public interface IButton
    {
        void OnClick(EventArgs e);
    }
}
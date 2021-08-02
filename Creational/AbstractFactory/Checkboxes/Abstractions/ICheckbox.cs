using AbstractFactory.Buttons.Abstractions;

namespace AbstractFactory.Checkboxes.Abstractions
{
    public interface ICheckbox
    {
        void SynchronizeStateWithButton(IButton button);
    }
}
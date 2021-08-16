using Composite.Graphics;

namespace Composite
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var imageEditor = new ImageEditor();

            var compoundGraphic = imageEditor.Load();
            imageEditor.GroupSelected(compoundGraphic.GetComponentsOfType<Circle>());
        }
    }
}
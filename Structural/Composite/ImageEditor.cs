using Composite.Graphics;
using Composite.Graphics.Abstraction;
using System.Collections.Generic;

namespace Composite
{
    internal class ImageEditor
    {
        private CompoundGraphic _compoundGraphic;

        public CompoundGraphic  Load()
        {
            _compoundGraphic = new();
            _compoundGraphic.Add(new Dot(1, 2));
            _compoundGraphic.Add(new Dot(3, 5));
            _compoundGraphic.Add(new Circle(5, 3, 10));
            _compoundGraphic.Add(new Circle(2, 3, 15));
            return _compoundGraphic;
        }

        public void GroupSelected(IEnumerable<IGraphic> components)
        {
            var group = new CompoundGraphic();

            foreach (var component in components)
            {
                group.Add(component);
                _compoundGraphic.Remove(component);
            }
            _compoundGraphic.Add(group);
            _compoundGraphic.Draw();
        }
    }
}
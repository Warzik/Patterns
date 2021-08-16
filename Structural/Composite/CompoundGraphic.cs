using Composite.Graphics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Composite
{
    public class CompoundGraphic : IGraphic
    {
        private readonly List<IGraphic> _children;

        public CompoundGraphic()
        {
            _children = new List<IGraphic>();
        }

        public void Add(IGraphic child)
        {
            _children.Add(child);

            PrintComponentToConsole("Added component: ",child);
        }

        public void Remove(IGraphic child)
        {
            _children.Remove(child);

            PrintComponentToConsole("Removed component: ", child);
        }

        public List<T> GetComponentsOfType<T>() where T: IGraphic
        {
           return _children.OfType<T>().ToList();
        }

        public void Draw()
        {
            _children.ForEach(child => child.Draw());
        }

        public void Move(int x, int y)
        {
            _children.ForEach(child => child.Move(x, y));
        }

        private static void PrintComponentToConsole(string text, IGraphic component)
        {
            Type type = component.GetType();

            Console.WriteLine(text + JsonSerializer.Serialize(Convert.ChangeType(component, type)));
        }
    }
}
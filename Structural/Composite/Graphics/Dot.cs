using Composite.Graphics.Abstraction;

namespace Composite.Graphics
{
    public class Dot : IGraphic
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            // Drawing
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
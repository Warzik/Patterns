namespace Composite.Graphics
{
    public class Circle : Dot
    {
        public int Radius { get; set; }
        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public void Draw() 
        {

        }

    }
}
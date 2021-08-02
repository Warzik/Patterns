namespace Adapter.Pegs
{
    public class SquarePeg
    {
        private readonly double _width;

        public SquarePeg(double width)
        {
            _width = width;
        }

        public double GetWidth()
        {
            return _width;
        }
    }
}
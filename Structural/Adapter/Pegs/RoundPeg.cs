namespace Adapter.Pegs
{
    public class RoundPeg
    {
        private readonly double _radius;

        public RoundPeg(double radius)
        {
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }
    }
}
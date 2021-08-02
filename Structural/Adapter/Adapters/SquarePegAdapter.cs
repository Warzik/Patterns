using Adapter.Pegs;
using System;

namespace Adapter.Adapters
{
    public class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg _squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg) :
            base(squarePeg.GetWidth())
        {
            _squarePeg = squarePeg;
        }

        new public double GetRadius()
        {
            return _squarePeg.GetWidth() * Math.Sqrt(2) / 2;
        }
    }
}
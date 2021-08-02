using Adapter.Adapters;
using Adapter.Pegs;

namespace Adapter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var roundPeg = new RoundPeg(5);
            hole.Fits(roundPeg); // true

            var smallSquerePeg = new SquarePeg(5);
            var largeSquerePeg = new SquarePeg(10);
            //hole.Fits(smallSquerePeg) // this won't compile (incompatible types)

            var smallSquerePegAdapter = new SquarePegAdapter(smallSquerePeg);
            var largeSquerePegAdapter = new SquarePegAdapter(largeSquerePeg);
            hole.Fits(smallSquerePegAdapter); // true
            hole.Fits(largeSquerePegAdapter);// false
        }
    }
}
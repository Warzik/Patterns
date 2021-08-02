using Builder.Engines.Abstractions;
using Builder.Gps.Abstractions;
using Builder.TripComputers.Abstractions;

namespace Builder
{
    public class Car
    {
        public int SeatsCount { get; set; }
        public IEngine Engine { get; set; }
        public ITripComputer TripComputer { get; set; }
        public IGps Gps { get; set; }
    }
}
using Builder.Engines.Abstractions;
using Builder.Gps.Abstractions;
using Builder.TripComputers.Abstractions;

namespace Builder.Builders.Abstractions
{
    public interface IBuilder
    {
        public void Reset();

        public void SetSeats(int seatsCount);

        public void SetEngine(IEngine engine);

        public void SetTripComputer(ITripComputer tripComputer);

        public void SetGps(IGps gps);
    }
}
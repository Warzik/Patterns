using Builder.Builders.Abstractions;
using Builder.Engines.Abstractions;
using Builder.Gps.Abstractions;
using Builder.TripComputers.Abstractions;

namespace Builder.Builders
{
    public class ManualBuilder : IBuilder
    {
        private CarManual _carManual;
        public void Reset()
        {
            _carManual = new CarManual();
        }

        public void SetEngine(IEngine engine)
        {
            _carManual.EngineDescription = "Engine Description";
        }

        public void SetGps(IGps gps)
        {
            _carManual.GpsInstruction = "Gps Instruction";
        }

        public void SetSeats(int seatsCount)
        {
            _carManual.SeatsCount = seatsCount;
        }

        public void SetTripComputer(ITripComputer tripComputer)
        {
            _carManual.TripComputerInstruction = "Trip Computer Instruction";
        }

        public CarManual GetProduct()
        {
            return _carManual;
        }
    }
}
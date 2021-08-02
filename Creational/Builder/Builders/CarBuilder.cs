using Builder.Builders.Abstractions;
using Builder.Engines.Abstractions;
using Builder.Gps.Abstractions;
using Builder.TripComputers.Abstractions;
using System;

namespace Builder.Builders
{
    public class CarBuilder : IBuilder
    {
        private Car _car;
        public void Reset()
        {
            _car = new Car();
        }

        public void SetEngine(IEngine engine)
        {
            _car.Engine = engine;
        }

        public void SetGps(IGps gps)
        {
            _car.Gps = gps;
        }

        public void SetSeats(int seatsCount)
        {
            _car.SeatsCount = seatsCount;
        }

        public void SetTripComputer(ITripComputer tripComputer)
        {
            _car.TripComputer = tripComputer;
        }

        public Car GetProduct()
        {
            return _car;
        }
    }
}
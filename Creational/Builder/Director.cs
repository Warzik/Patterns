using Builder.Builders;
using Builder.Builders.Abstractions;
using Builder.Engines;
using Builder.Gps;
using Builder.TripComputers;

namespace Builder
{
    public static class Director
    {
        public static void MakeSuv(IBuilder builder) 
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine(new StraightEngine());
            builder.SetTripComputer(new AdvancedTripComputer());
            builder.SetGps(new PlugInGPS());
        }
        public static void MakeSportsCar(IBuilder builder) 
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new VEngine());
            builder.SetTripComputer(new AdvancedTripComputer());
            builder.SetGps(new HardwiredGps());
        }
    }
}
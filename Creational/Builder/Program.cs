using Builder.Builders;

namespace Builder
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var carBuilder = new CarBuilder();
            Director.MakeSportsCar(carBuilder);
            var sportCar = carBuilder.GetProduct();

            var manualBuilder = new ManualBuilder();
            Director.MakeSportsCar(manualBuilder);
            var manual = manualBuilder.GetProduct();
        }
    }
}
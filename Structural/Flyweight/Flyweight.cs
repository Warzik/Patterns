using System;
using System.Text.Json;

namespace Flyweight
{
    public class Flyweight
    {
        private readonly Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string shared = JsonSerializer.Serialize(_sharedState);
            string unique = JsonSerializer.Serialize(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {shared} and unique {unique} state.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private readonly List<(Flyweight flyweight, int hash)> flyweights = new();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add((flyweight: new Flyweight(elem), hash: GetHash(elem)));
            }
        }

        public static int GetHash(Car key)
        {
            return JsonSerializer.Serialize(key).GetHashCode();
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            var currentHash = GetHash(sharedState);

            if (!flyweights.Any(t => t.hash == currentHash))
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                flyweights.Add((flyweight: new Flyweight(sharedState), hash: GetHash(sharedState)));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return flyweights.Find(t => t.hash == currentHash).flyweight;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.hash);
            }
        }
    }
}
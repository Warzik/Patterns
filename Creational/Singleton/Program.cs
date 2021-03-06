using System;
using System.Threading;

namespace Singleton
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused",
                "If you see different values, then 2 singletons were created",
                "RESULT:"
            );

            Thread process1 = new(() => TestSingleton("FOO"));
            Thread process2 = new(() => TestSingleton("BAR"));

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            var singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}

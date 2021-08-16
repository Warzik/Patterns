using Decorator.DataSource;
using Decorator.DataSource.Abstractions;
using System;

namespace Decorator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string key = "b14ca5898a4e4133bbce2ea2315a1916";

            IDataSource source = new FileDataSource("file.txt");
            source = new CompressionDecorator(source);
            source = new EncryptionDecorator(source, key);

            source.WriteData("Compressed and Encrypted Text");
            Console.WriteLine(source.ReadData());
        }
    }
}

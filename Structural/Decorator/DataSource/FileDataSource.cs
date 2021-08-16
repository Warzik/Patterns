using Decorator.DataSource.Abstractions;
using System.IO;

namespace Decorator.DataSource
{
    public class FileDataSource : IDataSource
    {
        private readonly string _filePath;

        public FileDataSource(string filePath)
        {
            _filePath = filePath;
        }

        public string ReadData()
        {
            return File.ReadAllText(_filePath);
        }

        public void WriteData(string data)
        {
            File.WriteAllText(_filePath, data);
        }
    }
}
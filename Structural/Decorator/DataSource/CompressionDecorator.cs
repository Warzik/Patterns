using Decorator.Common;
using Decorator.DataSource.Abstractions;

namespace Decorator.DataSource
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource wrappee) : base(wrappee)
        {
        }

        public override string ReadData()
        {
            return StringCompressor.Decompress(Wrappee.ReadData());
        }

        public override void WriteData(string data)
        {
            Wrappee.WriteData(StringCompressor.Compress(data));
        }
    }
}
using Decorator.Common;
using Decorator.DataSource.Abstractions;

namespace Decorator.DataSource
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        private readonly string _encryptionKey;

        public EncryptionDecorator(IDataSource wrappee, string encryptionKey) : base(wrappee)
        {
            _encryptionKey = encryptionKey;
        }

        public override string ReadData()
        {
            return AesEncryptor.DecryptString(_encryptionKey, Wrappee.ReadData());
        }

        public override void WriteData(string data)
        {
            Wrappee.WriteData(AesEncryptor.EncryptString(_encryptionKey, data));
        }
    }
}
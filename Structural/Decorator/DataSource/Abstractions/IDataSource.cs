namespace Decorator.DataSource.Abstractions
{
    public interface IDataSource
    {
        public void WriteData(string data);
        public string ReadData();
    }
}
namespace Decorator.DataSource.Abstractions
{
    public abstract class DataSourceDecorator : IDataSource
    {
        protected readonly IDataSource Wrappee;

        protected DataSourceDecorator(IDataSource wrappee)
        {
            Wrappee = wrappee;
        }

        public virtual string ReadData()
        {
            return Wrappee.ReadData();
        }

        public virtual void WriteData(string data)
        {
            Wrappee.WriteData(data);
        }
    }
}
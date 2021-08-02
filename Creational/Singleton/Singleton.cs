namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new();

        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton
                        {
                            Value = value
                        };
                    }
                }
            }
            return _instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public string Value { get; set; }
    }
}
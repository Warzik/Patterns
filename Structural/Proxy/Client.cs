using Proxy.Abstraction;

namespace Proxy
{
    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
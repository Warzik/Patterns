using ChainOfResponsibility.Abstraction;

namespace ChainOfResponsibility
{
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            return _nextHandler?.Handle(request);
        }
    }
}
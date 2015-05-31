using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebus.SimpleInjector
{
    public class FakeMessageContext : IMessageContext
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string ReturnAddress { get; }
        public string RebusTransportMessageId { get; }
        public IDictionary<string, object> Items { get; }
        public IReadOnlyCollection<Type> HandlersToSkip { get; }
        public void Abort()
        {
            throw new NotImplementedException();
        }

        public event Action Disposed;
        public object CurrentMessage { get; }
        public IDictionary<string, object> Headers { get; }
        public void SkipHandler(Type type)
        {
            throw new NotImplementedException();
        }

        public void DoNotSkipHandler(Type type)
        {
            throw new NotImplementedException();
        }
    }
}

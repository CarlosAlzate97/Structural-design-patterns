using Decorator_Pattern.Client;

namespace Decorator_Pattern.Decorator
{
    public class ClientDecorator : IClient
    {
        private readonly IClient _client;

        public ClientDecorator(IClient client)
        {
            _client = client;
        }

        public virtual bool Available()
        {
            return _client.Available();
        }

        public virtual bool Connect(string url, int port)
        {
            return _client.Connect(url, port);
        }

        public virtual string Read()
        {
            return _client.Read();
        }

        public virtual int Write(string message)
        {
            return _client.Write(message);
        }
    }
}
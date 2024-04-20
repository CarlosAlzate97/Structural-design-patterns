
namespace Decorator_Pattern.Client
{
    public interface IClient
    {
        bool Available();
        bool Connect(string url, int port);
        string Read();
        int Write(string message);
    }
}

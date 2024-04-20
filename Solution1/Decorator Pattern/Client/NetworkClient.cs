namespace Decorator_Pattern.Client
{
    internal class NetworkClient : IClient
    {
        // some variables to emulate server responses
        private const string _someReceivedMessage = "Some response message";
        private int _available = _someReceivedMessage.Length;

        public bool Available()
        {
            if (_available == _someReceivedMessage.Length)
                Console.WriteLine("NetworkClient.Available()");
            if (_available > 0)
                return true;

            // restart reading process for the next cycle
            _available = _someReceivedMessage.Length;
            return false;
        }

        public bool Connect(string url, int port)
        {
            Console.WriteLine($"NetworkClient.Connect({url},{port})");
            return true;
        }

        public string Read()
        {
            if (_available == 0)
                return string.Empty;

            _available = 0;
            Console.WriteLine("NetworkClient.Read()");

            return _someReceivedMessage;
        }

        public int Write(string message)
        {
            Console.WriteLine($"NetworkClient.Write({message})");
            return message.Length;
        }
    }
}
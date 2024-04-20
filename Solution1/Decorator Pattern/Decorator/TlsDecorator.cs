using Decorator_Pattern.Client;

namespace Decorator_Pattern.Decorator
{
    public class TlsDecorator : ClientDecorator
    {
        public TlsDecorator(IClient client) : base(client)
        {
        }

        public override bool Available()
        {
            Console.WriteLine("TlsDecorator.Available()");
            return base.Available();
        }

        public override bool Connect(string url, int port)
        {
            base.Connect(url, port);
            return TlsHandshake();
        }

        public override string Read()
        {
            return DencryptMessage(base.Read());
        }

        public override int Write(string message)
        {
            var encryptedMessage = EncryptMessage(message);
            return base.Write(encryptedMessage);
        }

        private static string EncryptMessage(string message)
        {
            Console.WriteLine("TLS decorator: Encrypting message...");
            return $"Encrypted message: {message}";
        }

        private static string DencryptMessage(string message)
        {
            Console.WriteLine("TLS decorator: Dencrypting message...");
            return $"Dencrypted message: {message}";
        }

        private static bool TlsHandshake()
        {
            Console.WriteLine("TLS Handshake");
            return true;
        }
    }
}
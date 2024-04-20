using Decorator_Pattern.Client;
using Decorator_Pattern.Decorator;
using System.Text;

public class Program
{
    public static void Main()
    {
        var innerClient = new NetworkClient();
        var tlsClient = new TlsDecorator(innerClient);
        var client = new TrackingDecorator(tlsClient);

        if (!client.Connect("some.server.com", 502))
            return;
        
        Console.WriteLine("client connected");
        client.Write("some message");

        var strBuilder = new StringBuilder();
        if (client.Available())
            strBuilder.Append(client.Read());

        Console.WriteLine();
        Console.WriteLine("====== App ======");
        Console.WriteLine($"response message: {strBuilder.ToString()}");
        Console.WriteLine($"Log messages:");
        foreach(var item in client.Log)
            Console.WriteLine(item);
    }
}
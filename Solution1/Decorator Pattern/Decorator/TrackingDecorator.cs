using Decorator_Pattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public class TrackingDecorator : ClientDecorator
    {
        public List<string> Log {  get; set; }

        public TrackingDecorator(IClient client) : base(client)
        {
            Log = new List<string>();
        }

        public override bool Available()
        {
            Console.WriteLine("TrackingDecorator.Available()");
            Log.Add("LogMsg: Available");
            return base.Available();
        }

        public override bool Connect(string url, int port)
        {
            Console.WriteLine("TrackingDecorator.Connect()");
            Log.Add("LogMsg: Connect");
            return base.Connect(url, port);
        }

        public override string Read()
        {
            Console.WriteLine("TrackingDecorator.Read()");
            Log.Add("LogMsg: Read");
            return base.Read();
        }

        public override int Write(string message)
        {
            Console.WriteLine($"TrackingDecorator.write({message})");
            Log.Add("LogMsg: Read");
            return base.Write(message);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Registry : IAccess
    {
        private readonly string userId;

        public Registry(string userId)
        {
            this.userId = userId;
        }

        public void Access()
        {
            Console.WriteLine("Se accedió correctamente al registro");
        }

    }
}

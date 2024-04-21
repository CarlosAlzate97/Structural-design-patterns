using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RegistryProxy : IAccess
    {
        private string userId;
        private Registry registry;

        public RegistryProxy(string userId)
        {   
            this.userId = userId;
        }

        public void Access()
        {
            if (registry == null)
            { 
                registry = new Registry(userId);
                Console.WriteLine($"El usuario {userId} accedió a los datos el {DateTime.Now.ToString()}");
   
            }
            registry.Access();
        }
    }
}

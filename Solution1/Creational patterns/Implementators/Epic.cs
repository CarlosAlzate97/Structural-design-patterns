using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_patterns.Implementators
{
    public class Epic: IStepsToDeploy
    {
        string name = "Epic";
        public void ValidateCredentials()
        {
            Console.WriteLine($"Validating credentials for {name} platform");
        }
        public void IntegratePlatform()
        {
            Console.WriteLine($"Integrating {name} platform");   
        }
        public void SettingLaunchOptions()
        {
            Console.WriteLine($"Setting launch options from {name}");
        }
        public void Deploy()
        {
            Console.WriteLine($"Deploy to {name}");
        }
    }
}

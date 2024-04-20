using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_patterns.Implementators
{
    public interface IStepsToDeploy
    {
        public void ValidateCredentials();
        public void IntegratePlatform();
        public void SettingLaunchOptions();
        public void Deploy();
    }
}

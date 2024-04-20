using Creational_patterns.Implementators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_patterns.Abstractions
{
    public class GenericMOBAGame : Deployment
    {

        public GenericMOBAGame(IStepsToDeploy deployment) : base(deployment)
        {

        }
        public override void StartDeploy()
        {
            deployment.ValidateCredentials();
            deployment.IntegratePlatform();
            deployment.SettingLaunchOptions();
            deployment.Deploy();
        }

        public override void FinishDeploy()
        {
            Console.WriteLine("Finish Deploy");
        }


    }
}

using Creational_patterns.Implementators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_patterns.Abstractions
{
    public abstract class Deployment
    {
        protected IStepsToDeploy deployment;        

        public Deployment(IStepsToDeploy deployment)
        {
            this.deployment = deployment;
        }

        public abstract void StartDeploy();
        public abstract void FinishDeploy();
    }
}

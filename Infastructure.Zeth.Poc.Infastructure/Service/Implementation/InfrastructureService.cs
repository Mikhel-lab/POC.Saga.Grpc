using Infastructure.Zeth.Poc.Core;
using Infastructure.Zeth.Poc.Core.Interfaces;
using Infastructure.Zeth.Poc.Shared.Entities;
using Infastructure.Zeth.Poc.Shared.Helper;
using Microsoft.Extensions.Configuration;

namespace Infastructure.Zeth.Poc.Infastructure.Service.Implementation
{
    public class InfrastructureService : IInfastructure
    {
        private readonly IConfiguration _config;

        public InfrastructureService(IConfiguration config)
        {
            _config = config;
        }

        public bool ProvisionResources(InfastructureOnboarding onboarding)
        {
            var terraformExecutable = _config["Terraform:ExecutablePath"];
            var terraformWorkingDirectory = _config["Terraform:WorkingDirectory"];
            var terraformVars = new Dictionary<string, string>
        {
            { "customer_name", onboarding.Email },
            { "customer_email", onboarding.Email },
        };

            var result = TerraformHelper.Execute(terraformExecutable, terraformWorkingDirectory, "apply", terraformVars);

            if (result.ExitCode == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

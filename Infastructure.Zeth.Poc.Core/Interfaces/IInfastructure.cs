using Infastructure.Zeth.Poc.Shared.Entities;

namespace Infastructure.Zeth.Poc.Core.Interfaces
{
    public interface IInfastructure
    {
        bool ProvisionResources(InfastructureOnboarding onboarding);
    }
}


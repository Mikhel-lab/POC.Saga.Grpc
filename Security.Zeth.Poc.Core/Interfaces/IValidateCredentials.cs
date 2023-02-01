using Security.Zeth.Poc.Shared.Entities;

namespace Security.Zeth.Poc.Core.Interfaces
{
    public interface IValidateCredentials
    {
        bool ValidateCredential(SecurityOnboarding onboarding);
    }
}



using Security.Zeth.Poc.Core.Interfaces;
using Security.Zeth.Poc.Infastructure.Data;
using Security.Zeth.Poc.Shared.Entities;

namespace Security.Zeth.Poc.Infastructure.Service.Implementation
{
    public class ValidateCredentials : IValidateCredentials
    {
        private readonly SecurityDbContext _context;

        public ValidateCredentials(SecurityDbContext context)
        {
            _context = context;
        }

        public bool ValidateCredential(SecurityOnboarding onboarding)
        {
            var existingCustomer = _context.Onboardings.FirstOrDefault(x => x.Email == onboarding.Email);
            if (existingCustomer != null)
            {
                return existingCustomer.Email == onboarding.Email;
            }
            else
            {
                return false;
            }
        }
    }
}

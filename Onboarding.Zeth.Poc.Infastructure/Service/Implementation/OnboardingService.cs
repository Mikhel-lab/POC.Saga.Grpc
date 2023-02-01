using Onboarding.Zeth.Poc.Core.Interfaces;
using Onboarding.Zeth.Poc.Infastructure.Data;
using Onboarding.Zeth.Poc.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onboarding.Zeth.Poc.Infastructure.Service.Implementation
{
    public class OnboardingService : RepositoryBase<Onboard>, IOnboarding
    {
        public OnboardingService(OnboardDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Onboard> CreateOnboarding(Onboard onboard)
        {
            _dbContext.Onboards.Add(onboard);
            await _dbContext.SaveChangesAsync();
            return onboard;
        }
    }
}

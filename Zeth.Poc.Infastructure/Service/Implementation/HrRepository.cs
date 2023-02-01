using Hr.Zeth.Poc.Core.Interfaces;
using Hr.Zeth.Poc.Infastructure.Data;
using Hr.Zeth.Poc.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Zeth.Poc.Infastructure.Service.Implementation
{
    public class HrRepository : RepositoryBase<HrOnboarding>, IHrRepository
    {
        public HrRepository(HrDbContext dbContext) : base(dbContext)
        {
        }

        public async Task UpdateCustomerData(HrOnboarding onboarding)
        {
            _dbContext.Update<HrOnboarding>(onboarding);
            _dbContext.SaveChanges();
        }
    }
}


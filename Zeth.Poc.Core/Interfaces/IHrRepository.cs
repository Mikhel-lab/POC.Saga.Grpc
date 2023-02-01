using Hr.Zeth.Poc.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Zeth.Poc.Core.Interfaces
{
    public interface IHrRepository
    {
        Task UpdateCustomerData(HrOnboarding onboarding);
    }
}


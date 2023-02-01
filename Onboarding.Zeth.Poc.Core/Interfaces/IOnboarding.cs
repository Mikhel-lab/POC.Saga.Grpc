using Onboarding.Zeth.Poc.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onboarding.Zeth.Poc.Core.Interfaces
{
    public interface IOnboarding
    {
        Task<Onboard> CreateOnboarding(Onboard onboard);
    }
}

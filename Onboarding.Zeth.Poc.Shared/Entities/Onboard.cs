using Onboarding.Zeth.Poc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onboarding.Zeth.Poc.Shared.Entities
{
    public class Onboard : OnboardingEntityBase
    {
        public string RIN { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}

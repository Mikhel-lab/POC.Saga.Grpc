using Infastructure.Zeth.Poc.Shared.Common;

namespace Infastructure.Zeth.Poc.Shared.Entities
{
    public class InfastructureOnboarding : InfastructureEntityBase
    {
        public string RIN { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}


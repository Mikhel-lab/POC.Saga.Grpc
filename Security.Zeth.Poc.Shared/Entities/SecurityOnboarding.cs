using Security.Zeth.Poc.Shared.Common;

namespace Security.Zeth.Poc.Shared.Entities
{
    public class SecurityOnboarding : SecurityEntityBase
    {
        public string RIN { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}


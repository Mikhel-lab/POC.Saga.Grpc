using Onboarding.Zeth.Poc.API.Protos;

namespace OnboardingApi.OnboardingGrpcService
{
    public class OnboardingGrpcService
    {
        private readonly  OnboardProtoService.OnboardProtoServiceClient _client;


        public OnboardingGrpcService(OnboardProtoService.OnboardProtoServiceClient client)
        {
            _client = client;
        }

        public async Task<OnboardResponse> OnboardCustomer(OnboardRequest request)
        {
            var onboardingrequest = new OnboardRequest
            {
                RIN = request.RIN,
                Email = request.Email,
                Token = request.Token
            };

            return await _client.OnboardCustomerAsync(onboardingrequest);
        }
    }
}

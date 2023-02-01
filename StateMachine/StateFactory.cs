using Onboarding.Zeth.Poc.API.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateFactory
    {
        private readonly ILogger<StateFactory> logger;
        private readonly IConfiguration configuration;

        public StateFactory(ILogger<StateFactory> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }
        public Task<OnboardRequest> Generate()
        {
            var Onboarduser = $"{configuration.GetValue<string>("WorkerService:OnboardingMember")}_{DateTimeOffset.Now}";
            var request = new OnboardRequest
            {
                Email = Onboarduser,
                RIN = Onboarduser,
                Token = Onboarduser,
            };
            return Task.FromResult(request);
        }
    }
}

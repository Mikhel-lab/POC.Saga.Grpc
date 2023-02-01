using AutoMapper;
using Grpc.Core;
using Onboarding.Zeth.Poc.API.Protos;
using Onboarding.Zeth.Poc.Infastructure.Data;
using Onboarding.Zeth.Poc.Shared.Entities;

namespace Onboarding.Zeth.Poc.API.Service
{
    public class OnboardService : OnboardProtoService.OnboardProtoServiceBase
    {
        private readonly IMapper mapper;
        private readonly ILogger<OnboardService> _logger;
        private readonly OnboardDbContext _customer;

        public OnboardService(IMapper mapper, ILogger<OnboardService> logger, OnboardDbContext customer)
        {
            this.mapper = mapper;
            _logger = logger;
            _customer = customer;
        }

        public async override Task<OnboardResponse> OnboardCustomer(OnboardRequest request, ServerCallContext context)
        {
            var customer = mapper.Map<Onboard>(request);

            _customer.Onboards.Add(customer);
            await _customer.SaveChangesAsync();

            _logger.LogInformation("User successfully onboarded :", customer.RIN);

            var customerModel = mapper.Map<OnboardResponse>(customer);
            return customerModel;
        }

    }
}


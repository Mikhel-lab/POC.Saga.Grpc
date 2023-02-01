using AutoMapper;
using Grpc.Core;
using Hr.Zeth.Poc.API.Protos;
using Hr.Zeth.Poc.Infastructure.Data;
using HRGrpc.Mapper;
using Onboarding.Zeth.Poc.API.Service;

namespace Hr.Zeth.Poc.API.Service
{
    public class HrService : HrProtoService.HrProtoServiceBase
    {
        private readonly OnboardService user;
        private readonly IMapper mapper;
        private readonly ILogger<HrService> logger;
        private readonly HrDbContext _context;

        public HrService(OnboardService user, IMapper mapper, ILogger<HrService> logger, HrDbContext context)
        {
            this.user = user;
            this.mapper = mapper;
            this.logger = logger;
            _context = context;
        }

        public async Task<OnboardingResponse> GetOnboardingCustomer(Onboarding.Zeth.Poc.API.Protos.OnboardRequest request, ServerCallContext context)
        {
            try
            {
                var customerData = await user.OnboardCustomer(request, context);
                var customerResponse = mapper.Map<OnboardingResponse>(customerData);

                return customerResponse;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error Occured while getting user data");
                throw new RpcException(new Grpc.Core.Status(StatusCode.Internal, "Error Occured while getting customer data"));
            }
        }


        public override async Task GetAllOnboardingCustomer(AllOnboardingRequest request, IServerStreamWriter<OnboardingResponse> responseStream, ServerCallContext context)
        {
            var onblist =  _context.Onboardings.ToList();
            foreach (var product in onblist)
            {
                var onModel = mapper.Map<OnboardingResponse>(product);
                await responseStream.WriteAsync(onModel);
            }
             
        }

    }
}

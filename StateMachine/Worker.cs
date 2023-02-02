using Grpc.Net.Client;
using Hr.Zeth.Poc.API.Protos;
using Hr.Zeth.Poc.API.Service;
using Infastructure.Zeth.Poc.API.Protos;
using Microsoft.Extensions.Configuration;
using Onboarding.Zeth.Poc.API.Protos;
using Onboarding.Zeth.Poc.API.Service;
using Security.Zeth.Poc.API.Protos;

namespace StateMachine
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        private readonly StateFactory _stateFactory;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, StateFactory stateFactory)
        {
            _logger = logger;
            _configuration = configuration;
            _stateFactory = stateFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
              
                    ////1. get the onboarding user
                    //using var channel = GrpcChannel.ForAddress(_configuration.GetValue<string>("WorkerService:OnboardingMember"));
                    //var Onbclient = new OnboardProtoService(channel);
                    //var response = await Onbclient.OnboardCustomer(await _stateFactory.Generate());


                    ////2. Retrieve onboarding user for Hr from Onboarding table
                    //using var HrChannel = GrpcChannel.ForAddress(_configuration.GetValue<string>("WorkerService:HrServerUrl"));
                    //var hRClient = new HrProtoService.HrProtoServiceBase(productChannel);

                    ////3. Retrieve onboarding user for HR from Hr table
                    //using var InfastructureChannel = GrpcChannel.ForAddress(_configuration.GetValue<string>("WorkerService:InfastructureServerUrl"));
                    //var infastrClient = new InfastructureProtoService.InfastructureProtoServiceBase(InfastructureChannel);

                    ////4 Retrieve onboarding user for security from Infastructure table
                    //using var securityChannel = GrpcChannel.ForAddress(_configuration.GetValue<string>("WorkerService:SecurityServerUrl"));
                    //var productClient = new SecurityProtoService.SecurityProtoServiceBase(securityChannel);
             
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
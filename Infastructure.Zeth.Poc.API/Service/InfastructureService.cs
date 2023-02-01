using Grpc.Core;
using Infastructure.Zeth.Poc.API.Protos;
using Infastructure.Zeth.Poc.Infastructure.Data;
using Onboarding.Zeth.Poc.Infastructure.Data;

namespace Infastructure.Zeth.Poc.API.Service
{
    public class InfastructureService : InfastructureProtoService.InfastructureProtoServiceBase
    {
        private readonly InfastructureDbContext context;

        public InfastructureService(InfastructureDbContext context)
        {
            this.context = context;
        }

        public override Task<ProvisionResourcesResponse> ProvisionResources(ProvisionResourcesRequest request, ServerCallContext context)
        {
            var IsValid = IsProvisionResources(request);
            if (!IsValid)
            {
                return Task.FromResult(new ProvisionResourcesResponse
                {
                    Result = "Invalid user data"
                });
            }

            try
            {
                if (IsValid)
                {
                    return Task.FromResult(new ProvisionResourcesResponse
                    {
                        Result = "Your Resources were provisioned successfully"
                    });
                }
                else
                {
                    return Task.FromResult(new ProvisionResourcesResponse
                    {
                        Result = "Failed to provision resources"
                    });
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult(new ProvisionResourcesResponse
                {
                    Result = ex.Message
                });
            }
        }

        private bool IsProvisionResources(ProvisionResourcesRequest request)
        {
            var customer = context.Onboardings.FirstOrDefault(x => x.Id.Equals(request.Id));
            if (customer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

using Grpc.Core;
using Hr.Zeth.Poc.API.Service;
using Security.Zeth.Poc.API.Protos;
using Security.Zeth.Poc.Infastructure.Data;

namespace Security.Zeth.Poc.API.Service
{
    public class SecurityService : SecurityProtoService.SecurityProtoServiceBase
    {
        private readonly HrService hrService;
        private readonly SecurityDbContext context;

        public SecurityService(HrService hrService, SecurityDbContext context)
        {
            this.hrService = hrService;
            this.context = context;
        }

        public override Task<ValidateCredentialsResponse> ValidateCredentials(ValidateCredentialsRequest request, ServerCallContext context)
        {
            var isValid = Validate(request);
            if (!isValid)
            {
                return Task.FromResult(new ValidateCredentialsResponse
                {
                    Result = "Invalid user"
                });
            }

            try
            {

                if (isValid)
                {
                    return Task.FromResult(new ValidateCredentialsResponse
                    {
                        Result = "Credentials are valid and Access granted for all systems"
                    });
                }
                else
                {
                    return Task.FromResult(new ValidateCredentialsResponse
                    {
                        Result = "Invalid credentials and Access not granted"
                    });
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult(new ValidateCredentialsResponse
                {
                    Result = ex.Message
                });
            }
        }


        private bool Validate(ValidateCredentialsRequest request)
        {
            var customer = context.Onboardings.FirstOrDefault(x => x.RIN == request.RIN);
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

using Microsoft.AspNetCore.Mvc;
using System.Net;
using Onboarding.Zeth.Poc.API.Protos;
using OnboardingApi.OnboardingGrpcService;

namespace Onboarding.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OnboardController : ControllerBase
    {
        private readonly OnboardingGrpcService _grpcService;
        public OnboardController(OnboardingGrpcService grpcService)
        {
            _grpcService = grpcService;
        }

        [HttpPost]
        public async Task<ActionResult<OnboardResponse>> OnboardUser([FromBody] OnboardRequest request)
        {
            var response = await _grpcService.OnboardCustomer(request);
            return Ok(response);
        }

        
    }

}


using Microsoft.AspNetCore.Mvc;
using Onboarding.Zeth.Poc.Core.Interfaces;
using Onboarding.Zeth.Poc.Shared.Entities;
using System.Net;

namespace Onboarding.Zeth.Poc.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OnboardController : ControllerBase
    {
        private readonly IOnboarding _repository;

        public OnboardController(IOnboarding repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Onboard), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Onboard>> OnboardUser([FromBody] Onboard onboard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _repository.CreateOnboarding(onboard);
            return Ok(onboard);
        }

        
    }

}


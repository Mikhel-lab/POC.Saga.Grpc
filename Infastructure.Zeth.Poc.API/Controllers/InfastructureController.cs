using Infastructure.Zeth.Poc.Core.Interfaces;
using Infastructure.Zeth.Poc.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infastructure.Zeth.Poc.API.Controllers
{
    [ApiController]
    public class InfastructureController : Controller
    {
        private readonly IInfastructure _infrastructureService;

        public InfastructureController(IInfastructure infrastructureService)
        {
            _infrastructureService = infrastructureService;
        }

        [Route("api/v1/infastructure/{provision}")]
        [HttpPost]
        public IActionResult ProvisionResources([FromBody] InfastructureOnboarding onboarding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var isProvisioned = _infrastructureService.ProvisionResources(onboarding);
                if (isProvisioned)
                {
                    return Ok("Resources were provisioned successfully");
                }
                else
                {
                    return BadRequest("Failed to provision resources");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("api/v1/infastructure/{resource}")]
        [HttpGet]
        public IActionResult Resources([FromBody] InfastructureOnboarding onboarding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var isProvisioned = _infrastructureService.ProvisionResources(onboarding);
                if (isProvisioned)
                {
                    return Ok("Resources were provisioned successfully");
                }
                else
                {
                    return BadRequest("Failed to provision resources");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}

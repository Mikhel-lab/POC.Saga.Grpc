using Microsoft.AspNetCore.Mvc;
using Onboarding.Zeth.Poc.Shared.Entities;
using Security.Zeth.Poc.Core.Interfaces;
using Security.Zeth.Poc.Shared.Entities;
using System.Net;

namespace Security.Zeth.Poc.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SecurityController : ControllerBase
    {
        private readonly IValidateCredentials _validate;

        public SecurityController(IValidateCredentials validate)
        {
            _validate = validate;
        }

        [HttpPost]
        [ProducesResponseType(typeof(SecurityOnboarding), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<SecurityOnboarding>> ValidateCredentials([FromBody] SecurityOnboarding onboarding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var isValid = _validate.ValidateCredential(onboarding);
                if (isValid)
                {
                    return Ok("Credentials are valid");
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       

    }
}

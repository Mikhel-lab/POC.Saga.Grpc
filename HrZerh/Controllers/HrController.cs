using Hr.Zeth.Poc.Core.Interfaces;
using Hr.Zeth.Poc.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Hr.Zeth.Poc.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HrController : ControllerBase
    {
        private readonly IHrRepository _repository;
        public HrController(IHrRepository repository)
        {
            _repository = repository;
        }

        //[HttpGet]
        //public async Task<IActionResult> CatchAll([FromBody] HrOnboarding onboarding)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        //call the service method to update information in the database
        //        await _repository.UpdateCustomerData(onboarding);
        //        return Ok(onboarding);
        //    }
        //    catch (Exception ex)
        //    {

        //        return StatusCode(500, ex.Message);
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> Catch([FromBody]HrOnboarding onboarding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //call the service method to update information in the database
                await _repository.UpdateCustomerData(onboarding);
                return Ok(onboarding);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}

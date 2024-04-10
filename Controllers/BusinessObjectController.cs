using HynEcom.IdentityServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HynEcom.IdentityServer.Controllers
{
    [Route("api/business-object")]
    public class BusinessObjectController : Controller
    {
        private readonly IBusinessObjectService _iBusinessObjectService;
        public BusinessObjectController(IBusinessObjectService iBusinessObjectService)
        {
            _iBusinessObjectService = iBusinessObjectService;
        }
        [HttpPost]
        [Route("create-async")]
        public async Task<IActionResult> CreateAsync([FromBody] BusinessObjectRequest request)
        {
            try
            {
                if (request == null) throw new ArgumentNullException(nameof(request));

                return Ok(await _iBusinessObjectService.CreateAsync(request));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("get-paging")]
        public async Task<IActionResult> GetDataPaging(PagedResultRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            return Ok(await _iBusinessObjectService.GetAllAsync(request));
        }
    }
}

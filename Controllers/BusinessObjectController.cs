using HynEcom.IdentityServer.EntityFrameworkCore;
using HynEcom.IdentityServer.Models;
using HynEcom.IdentityServer.Models.BaseService;
using Microsoft.AspNetCore.Mvc;

namespace HynEcom.IdentityServer.Controllers
{
    [Route("api/business-object")]
    public class BusinessObjectController : Controller
    {
        private readonly IBusinessObjectService _iBusinessObjectService;
        private readonly string _tableName;

        private readonly IBaseService _baseService;
        public BusinessObjectController(
            IBusinessObjectService iBusinessObjectService,
            IBaseService baseService)
        {
            _iBusinessObjectService = iBusinessObjectService;
            _baseService = baseService;
            _tableName = "BusinessObjects";
        }

        [HttpGet]
        [Route("get-paging")]
        public async Task<IActionResult> GetDataPaging(PagedResultRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            return Ok(await _iBusinessObjectService.GetAllAsync(request));
        }

        [HttpGet]
        [Route("get-by-ids")]
        public async Task<IActionResult> GetDataByIds(List<Guid> ids)
        {
            if (ids == null) throw new ArgumentNullException(nameof(ids));

            return Ok(await _iBusinessObjectService.GetByIds(ids));
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

        [HttpDelete]
        [Route("hard-delete-nultiple")]
        public async Task<IActionResult> MultipleHardDeteledAsync(List<Guid> ids)
        {
            try
            {
                if (ids != null)
                {
                    if (_iBusinessObjectService.GetByIds(ids) == null)
                    {
                        BadRequest();
                    };
                    return Ok(await _baseService.MultipleHardDeteledAsync(ids, DbProperties.DbSchemaIdentity, _tableName));
                }
                else { throw new ArgumentNullException(nameof(ids)); }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("soft-delete-nultiple")]
        public async Task<IActionResult> MultipleSoftDeteledAsync(List<Guid> ids)
        {
            try
            {
                if (ids != null)
                {
                    if (_iBusinessObjectService.GetByIds(ids) == null)
                    {
                        BadRequest();
                    };
                    return Ok(await _baseService.MultipleSoftDeteledAsync(ids, DbProperties.DbSchemaIdentity, _tableName));
                }
                else { throw new ArgumentNullException(nameof(ids)); }
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}

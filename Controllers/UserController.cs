using Microsoft.AspNetCore.Mvc;

namespace HynEcom.IdentityServer.Controllers
{
    [Route ("api/user")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route ("get-all")]
        public IActionResult GetUserAsync()
        {
            return View();
        }

        [HttpGet]
        [Route("get-by-id")]
        public IActionResult GetUserByIdAsync()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateAsync()
        {
            return View();
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateAsync()
        {
            return View();
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteAsync()
        {
            return View();
        }
    }
}

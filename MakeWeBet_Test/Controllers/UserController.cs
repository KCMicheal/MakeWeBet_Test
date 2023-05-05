using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MakeWeBet_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {

        }
    }
}

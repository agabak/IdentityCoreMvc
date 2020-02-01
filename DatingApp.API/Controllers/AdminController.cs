using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController:ControllerBase
    {
        public IActionResult GetUserWithRoles()
        {
            return Ok("Admin olny");
        }


        public IActionResult GetPhotoForUser()
        {
            return Ok("User photo");
        }
    }
}
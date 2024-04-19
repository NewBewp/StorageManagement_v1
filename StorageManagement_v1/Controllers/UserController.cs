using Microsoft.AspNetCore.Mvc;
using StorageManagement_v1.Models;

namespace StorageManagement_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "User")]
        public IEnumerable<User> Get()
        {
            using (var user = new StorageManagementContext()) {
                return user.Users.ToList();
            }
        }
    }


}


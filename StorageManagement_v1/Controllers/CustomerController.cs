using Microsoft.AspNetCore.Mvc;
using StorageManagement_v1.Models;

namespace StorageManagement_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet(Name = "Customer")]
        public IEnumerable<Customer> Get()
        {
            using (var customer = new StorageManagementContext()) {
                return customer.Customers.ToList();
            }
        }
    }


}


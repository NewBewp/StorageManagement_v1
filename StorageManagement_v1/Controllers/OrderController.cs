using Microsoft.AspNetCore.Mvc;
using StorageManagement_v1.Models;

namespace StorageManagement_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet(Name = "Order")]
        public IEnumerable<Order> Get()
        {
            using (var order = new StorageManagementContext()) {
                return order.Orders.ToList();
            }
        }
    }
}


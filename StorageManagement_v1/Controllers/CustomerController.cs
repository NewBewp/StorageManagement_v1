using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StorageManagement_v1.DTOs.CustomerDTO;
using StorageManagement_v1.Models;

namespace StorageManagement_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly StorageManagementContext _context;
        private readonly IMapper _mapper;

        public CustomerController(StorageManagementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllCustomers")]
        public async Task<IActionResult>  GetAllCustomers()
        {
            var customer = await _context.Customers.ToListAsync();
            var model = _mapper.Map<Customer[]>(customer);
            return Ok(model);
        }

        [HttpGet("{id}",Name = "GetCustomerById")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            var model = _mapper.Map<Customer>(customer);
            return Ok(model);
        }

        [HttpPost (Name ="CreateCustomer")]
        public async Task<IActionResult> PostCustomer([FromBody]CreateCustomerDTO createCustomerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map<Customer>(createCustomerDTO);
            await _context.Customers.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut("{id}", Name = "UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] UpdateCustomerDTO updateCustomerDTO)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map(updateCustomerDTO, customer);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}


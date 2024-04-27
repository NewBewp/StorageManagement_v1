using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StorageManagement_v1.DTOs.ProductDTO;
using StorageManagement_v1.Models;

namespace StorageManagement_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        //private readonly ILogger<ProductController> _logger;
        private readonly StorageManagementContext _context;
        private readonly IMapper _mapper;

        public ProductController(StorageManagementContext context, IMapper mapper)
        {
            //_logger = logger;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllProducts")]
        public IActionResult GetProductsAll()
        {
            var products = _context.Products.ToList();
            var model = _mapper.Map<ProductDTO[]>(products);
            return Ok(model);
        }

        [HttpGet("GetProductBy/{id}", Name = "GetProductByID")]
        public IActionResult GetProductsById(int id)
        {
            var products = _context.Products.Find(id);     
            if(products == null)
            {
                return NotFound();
            }
            var model = _mapper.Map<ProductDTO>(products);
            return Ok(model);
        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProducts([FromBody] CreateProductDTO createProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map<Product>(createProduct);
            _context.Products.Add(model);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProductsById), new { id = model.ProductId }, model);    
        }

        [HttpPut("id",Name = "UpdateProduct")]
        public IActionResult UpdateProduct(int id, [FromBody] UpdateProductDTO updateProductDTO)
        {
            var productsUpdate = _context.Products.Find(id);
            if(productsUpdate == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map(updateProductDTO, productsUpdate);
           
            _context.SaveChanges();
            return Ok(model);
        }
    }
}
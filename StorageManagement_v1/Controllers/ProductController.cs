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
        private readonly StorageManagementContext _context;
        private readonly IMapper _mapper;

        public ProductController(StorageManagementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var product = _context.Products.ToList();
            var model = _mapper.Map<ProductDTO[]>(product);
            return Ok(model);
        }

        [HttpGet("GetProductBy/{id}", Name = "GetProductById")]
        public IActionResult GetProductsById(int id)
        {
            var product = _context.Products.Find(id);     
            if(product == null)
            {
                return NotFound();
            }
            var model = _mapper.Map<ProductDTO>(product);
            return Ok(model);
        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProducts([FromBody] CreateProductDTO createProductDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map<Product>(createProductDTO);
            _context.Products.Add(model);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProductsById), new { id = model.ProductId }, model);    
        }

        [HttpPut("{id}",Name = "UpdateProduct")]
        public IActionResult UpdateProduct(int id, [FromBody] UpdateProductDTO updateProductDTO)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = _mapper.Map(updateProductDTO, product);           
            _context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("{id}", Name ="DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            var productToDelete = _context.Products.Find(id);
            if (productToDelete == null)
            {
                return NotFound();
            }
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
            return Ok(productToDelete);
        }
    }
}
using AspireApp4.ApiService.Data;
using AspireApp4.ApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspireApp4.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ProductController(DataDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var listodEmployees = await _context.Products.ToListAsync();
            return Ok(listodEmployees);
        }

        [HttpPost]
        public async Task<bool> AddProduct([FromBody] Product products)
        {
            try
            {
                await _context.Products.AddAsync(products);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return true;
        }

    }
}

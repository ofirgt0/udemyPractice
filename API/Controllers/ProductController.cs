using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext context){
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<List<product>>> GetProducts(){
            return Ok(await _context.Products.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<product>> GetProduct(int id){
            return await _context.Products.FindAsync(id);
        }
    }
}
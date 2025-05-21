   using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using u21516775_HW01_API.Models;

namespace u21516775_HW01_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public ProductDetailController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/ProductDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDetail>>> GetProductDetails()
        {
            var products = await _context.ProductDetails
                                 .OrderByDescending(p => p.ProductId) // Newest first
                                 .ToListAsync();
            return Ok(products);
        }

        // GET: api/ProductDetail/5
        [HttpGet("{id}")]  
        public async Task<ActionResult<ProductDetail>> GetProductDetail(int id)
        {
            var productDetail = await _context.ProductDetails.FindAsync(id);

            if (productDetail == null)
            {
                return NotFound();
            }

            return productDetail;
        }

        // PUT: api/ProductDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductDetail(int id, ProductDetail productDetail)
        {
            if (id != productDetail.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(productDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductDetail>> PostProductDetail(ProductDetail productDetail)
        {
            _context.ProductDetails.Add(productDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductDetail", new { id = productDetail.ProductId }, productDetail);
        }

        // DELETE: api/ProductDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetail(int id)
        {
            var productDetail = await _context.ProductDetails.FindAsync(id);
            if (productDetail == null)
            {
                return NotFound();
            }

            _context.ProductDetails.Remove(productDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductDetailExists(int id)
        {
            return _context.ProductDetails.Any(e => e.ProductId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly WebApiContext _context;

        public ProductTypesController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/ProductTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetProductType()
        {
          if (_context.ProductType == null)
          {
              return NotFound();
          }
            return await _context.ProductType.ToListAsync();
        }

        // GET: api/ProductTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductType(string id)
        {
          if (_context.ProductType == null)
          {
              return NotFound();
          }
            var productType = await _context.ProductType.FindAsync(id);

            if (productType == null)
            {
                return NotFound();
            }

            return productType;
        }

        // PUT: api/ProductTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductType(string id, ProductType productType)
        {
            if (id != productType.fcskid)
            {
                return BadRequest();
            }

            _context.Entry(productType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeExists(id))
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

        //// POST: api/ProductTypes
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<ProductType>> PostProductType(ProductType productType)
        //{
        //  if (_context.ProductType == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.ProductType'  is null.");
        //  }
        //    _context.ProductType.Add(productType);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProductTypeExists(productType.fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetProductType", new { id = productType.fcskid }, productType);
        //}

        //// DELETE: api/ProductTypes/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProductType(string id)
        //{
        //    if (_context.ProductType == null)
        //    {
        //        return NotFound();
        //    }
        //    var productType = await _context.ProductType.FindAsync(id);
        //    if (productType == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ProductType.Remove(productType);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool ProductTypeExists(string id)
        {
            return (_context.ProductType?.Any(e => e.fcskid == id)).GetValueOrDefault();
        }
    }
}

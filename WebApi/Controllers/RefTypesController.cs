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
    public class RefTypesController : ControllerBase
    {
        private readonly WebApiContext _context;

        public RefTypesController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/RefTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefType>>> GetRefType()
        {
          if (_context.RefType == null)
          {
              return NotFound();
          }
            return await _context.RefType.ToListAsync();
        }

        // GET: api/RefTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RefType>> GetRefType(string id)
        {
          if (_context.RefType == null)
          {
              return NotFound();
          }
            var refType = await _context.RefType.FindAsync(id);

            if (refType == null)
            {
                return NotFound();
            }

            return refType;
        }

        // PUT: api/RefTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefType(string id, RefType refType)
        {
            if (id != refType.fcskid)
            {
                return BadRequest();
            }

            _context.Entry(refType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefTypeExists(id))
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

        // POST: api/RefTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RefType>> PostRefType(RefType refType)
        {
          if (_context.RefType == null)
          {
              return Problem("Entity set 'WebApiContext.RefType'  is null.");
          }
            _context.RefType.Add(refType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RefTypeExists(refType.fcskid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRefType", new { id = refType.fcskid }, refType);
        }

        // DELETE: api/RefTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRefType(string id)
        {
            if (_context.RefType == null)
            {
                return NotFound();
            }
            var refType = await _context.RefType.FindAsync(id);
            if (refType == null)
            {
                return NotFound();
            }

            _context.RefType.Remove(refType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RefTypeExists(string id)
        {
            return (_context.RefType?.Any(e => e.fcskid == id)).GetValueOrDefault();
        }
    }
}

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
    public class EmployeeController : ControllerBase
    {
        private readonly WebApiContext _context;

        public EmployeeController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emplr>>> GetEmplr()
        {
          if (_context.Emplr == null)
          {
              return NotFound();
          }
            return await _context.Emplr.ToListAsync();
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emplr>> GetEmplr(string id)
        {
          if (_context.Emplr == null)
          {
              return NotFound();
          }
            var emplr = await _context.Emplr.FindAsync(id);

            if (emplr == null)
            {
                return NotFound();
            }

            return emplr;
        }

        // PUT: api/Employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmplr(string id, Emplr emplr)
        {
            if (id != emplr.Fcskid)
            {
                return BadRequest();
            }

            _context.Entry(emplr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmplrExists(id))
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

        // POST: api/Employee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Emplr>> PostEmplr(Emplr emplr)
        {
          if (_context.Emplr == null)
          {
              return Problem("Entity set 'WebApiContext.Emplr'  is null.");
          }
            _context.Emplr.Add(emplr);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmplrExists(emplr.Fcskid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmplr", new { id = emplr.Fcskid }, emplr);
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmplr(string id)
        {
            if (_context.Emplr == null)
            {
                return NotFound();
            }
            var emplr = await _context.Emplr.FindAsync(id);
            if (emplr == null)
            {
                return NotFound();
            }

            _context.Emplr.Remove(emplr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmplrExists(string id)
        {
            return (_context.Emplr?.Any(e => e.Fcskid == id)).GetValueOrDefault();
        }
    }
}

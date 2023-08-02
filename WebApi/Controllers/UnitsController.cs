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
    public class UnitsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public UnitsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Units
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unit>>> GetUnit()
        {
            if (_context.Unit == null)
            {
                return NotFound();
            }
            return await _context.Unit.ToListAsync();
        }

        // GET: api/Units/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Unit>> GetUnit(string id)
        {
            if (_context.Unit == null)
            {
                return NotFound();
            }
            var unit = await _context.Unit.FindAsync(id);

            if (unit == null)
            {
                return NotFound();
            }

            return unit;
        }

        // PUT: api/Units/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnit(string id, Unit unit)
        {
            if (id != unit.Fcskid)
            {
                return BadRequest();
            }

            _context.Entry(unit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitExists(id))
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

        //// POST: api/Units
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Unit>> PostUnit(Unit unit)
        //{
        //  if (_context.Unit == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Unit'  is null.");
        //  }
        //    _context.Unit.Add(unit);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (UnitExists(unit.Fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetUnit", new { id = unit.Fcskid }, unit);
        //}

        //// DELETE: api/Units/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUnit(string id)
        //{
        //    if (_context.Unit == null)
        //    {
        //        return NotFound();
        //    }
        //    var unit = await _context.Unit.FindAsync(id);
        //    if (unit == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Unit.Remove(unit);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool UnitExists(string id)
        {
            return (_context.Unit?.Any(e => e.Fcskid == id)).GetValueOrDefault();
        }
    }
}

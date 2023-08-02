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
    public class AccbooksController : ControllerBase
    {
        private readonly WebApiContext _context;

        public AccbooksController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Accbooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Accbook>>> GetAccbook()
        {
            if (_context.Accbook == null)
            {
                return NotFound();
            }
            return await _context.Accbook.ToListAsync();
        }

        // GET: api/Accbooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Accbook>> GetAccbook(string id)
        {
            if (_context.Accbook == null)
            {
                return NotFound();
            }
            var accbook = await _context.Accbook.FindAsync(id);

            if (accbook == null)
            {
                return NotFound();
            }

            return accbook;
        }

        // PUT: api/Accbooks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccbook(string id, Accbook accbook)
        {
            if (id != accbook.fcskid)
            {
                return BadRequest();
            }

            _context.Entry(accbook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccbookExists(id))
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

        //// POST: api/Accbooks
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Accbook>> PostAccbook(Accbook accbook)
        //{
        //  if (_context.Accbook == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Accbook'  is null.");
        //  }
        //    _context.Accbook.Add(accbook);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (AccbookExists(accbook.fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetAccbook", new { id = accbook.fcskid }, accbook);
        //}

        //// DELETE: api/Accbooks/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAccbook(string id)
        //{
        //    if (_context.Accbook == null)
        //    {
        //        return NotFound();
        //    }
        //    var accbook = await _context.Accbook.FindAsync(id);
        //    if (accbook == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Accbook.Remove(accbook);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool AccbookExists(string id)
        {
            return (_context.Accbook?.Any(e => e.fcskid == id)).GetValueOrDefault();
        }
    }
}

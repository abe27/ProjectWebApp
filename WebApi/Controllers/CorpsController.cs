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
    public class CorpsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public CorpsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Corps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Corp>>> GetCorp()
        {
            if (_context.Corp == null)
            {
                return NotFound();
            }
            return await _context.Corp.ToListAsync();
        }

        // GET: api/Corps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Corp>> GetCorp(string id)
        {
            if (_context.Corp == null)
            {
                return NotFound();
            }
            var corp = await _context.Corp.FindAsync(id);

            if (corp == null)
            {
                return NotFound();
            }

            return corp;
        }

        // PUT: api/Corps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorp(string id, Corp corp)
        {
            if (id != corp.fcskid)
            {
                return BadRequest();
            }

            _context.Entry(corp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CorpExists(id))
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

        //// POST: api/Corps
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Corp>> PostCorp(Corp corp)
        //{
        //  if (_context.Corp == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Corp'  is null.");
        //  }
        //    _context.Corp.Add(corp);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (CorpExists(corp.fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetCorp", new { id = corp.fcskid }, corp);
        //}

        //// DELETE: api/Corps/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCorp(string id)
        //{
        //    if (_context.Corp == null)
        //    {
        //        return NotFound();
        //    }
        //    var corp = await _context.Corp.FindAsync(id);
        //    if (corp == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Corp.Remove(corp);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool CorpExists(string id)
        {
            return (_context.Corp?.Any(e => e.fcskid == id)).GetValueOrDefault();
        }
    }
}

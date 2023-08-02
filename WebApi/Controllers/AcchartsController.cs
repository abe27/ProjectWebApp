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
    public class AcchartsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public AcchartsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Accharts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acchart>>> GetAcchart()
        {
            if (_context.Acchart == null)
            {
                return NotFound();
            }
            return await _context.Acchart.ToListAsync();
        }

        // GET: api/Accharts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acchart>> GetAcchart(string id)
        {
            if (_context.Acchart == null)
            {
                return NotFound();
            }
            var acchart = await _context.Acchart.FindAsync(id);

            if (acchart == null)
            {
                return NotFound();
            }

            return acchart;
        }

        // PUT: api/Accharts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcchart(string id, Acchart acchart)
        {
            if (id != acchart.fcskid)
            {
                return BadRequest();
            }

            _context.Entry(acchart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcchartExists(id))
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

        //// POST: api/Accharts
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Acchart>> PostAcchart(Acchart acchart)
        //{
        //  if (_context.Acchart == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Acchart'  is null.");
        //  }
        //    _context.Acchart.Add(acchart);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (AcchartExists(acchart.fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetAcchart", new { id = acchart.fcskid }, acchart);
        //}

        //// DELETE: api/Accharts/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAcchart(string id)
        //{
        //    if (_context.Acchart == null)
        //    {
        //        return NotFound();
        //    }
        //    var acchart = await _context.Acchart.FindAsync(id);
        //    if (acchart == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Acchart.Remove(acchart);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool AcchartExists(string id)
        {
            return (_context.Acchart?.Any(e => e.fcskid == id)).GetValueOrDefault();
        }
    }
}

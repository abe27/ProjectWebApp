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
    public class ProjsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public ProjsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Projs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proj>>> GetProj()
        {
            if (_context.Proj == null)
            {
                return NotFound();
            }
            return await _context.Proj.ToListAsync();
        }

        // GET: api/Projs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proj>> GetProj(string id)
        {
            if (_context.Proj == null)
            {
                return NotFound();
            }
            var proj = await _context.Proj.FindAsync(id);

            if (proj == null)
            {
                return NotFound();
            }

            return proj;
        }

        // PUT: api/Projs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProj(string id, Proj proj)
        {
            if (id != proj.Fcskid)
            {
                return BadRequest();
            }

            _context.Entry(proj).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjExists(id))
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

        //// POST: api/Projs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Proj>> PostProj(Proj proj)
        //{
        //  if (_context.Proj == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Proj'  is null.");
        //  }
        //    _context.Proj.Add(proj);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProjExists(proj.Fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetProj", new { id = proj.Fcskid }, proj);
        //}

        //// DELETE: api/Projs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProj(string id)
        //{
        //    if (_context.Proj == null)
        //    {
        //        return NotFound();
        //    }
        //    var proj = await _context.Proj.FindAsync(id);
        //    if (proj == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Proj.Remove(proj);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool ProjExists(string id)
        {
            return (_context.Proj?.Any(e => e.Fcskid == id)).GetValueOrDefault();
        }
    }
}

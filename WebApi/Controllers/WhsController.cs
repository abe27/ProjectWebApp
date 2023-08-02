using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public WhsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Whs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Whs>>> GetWhs()
        {
            if (_context.Whs == null)
            {
                return NotFound();
            }
            return await _context.Whs.ToListAsync();
        }

        // GET: api/Whs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Whs>> GetWhs(string id)
        {
            if (_context.Whs == null)
            {
                return NotFound();
            }
            var whs = await _context.Whs.FindAsync(id);

            if (whs == null)
            {
                return NotFound();
            }

            return whs;
        }

        // PUT: api/Whs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWhs(string id, Whs whs)
        {
            if (id != whs.Fcskid)
            {
                return BadRequest();
            }

            _context.Entry(whs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WhsExists(id))
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

        //// POST: api/Whs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Whs>> PostWhs(Whs whs)
        //{
        //  if (_context.Whs == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Whs'  is null.");
        //  }
        //    _context.Whs.Add(whs);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (WhsExists(whs.Fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetWhs", new { id = whs.Fcskid }, whs);
        //}

        //// DELETE: api/Whs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteWhs(string id)
        //{
        //    if (_context.Whs == null)
        //    {
        //        return NotFound();
        //    }
        //    var whs = await _context.Whs.FindAsync(id);
        //    if (whs == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Whs.Remove(whs);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool WhsExists(string id)
        {
            return (_context.Whs?.Any(e => e.Fcskid == id)).GetValueOrDefault();
        }
    }
}

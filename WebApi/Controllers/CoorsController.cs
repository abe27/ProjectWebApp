using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoorsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public CoorsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Coors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coor>>> GetCoor()
        {
            if (_context.Coor == null)
            {
                return NotFound();
            }
            return await _context.Coor.ToListAsync();
        }

        // GET: api/Coors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coor>> GetCoor(string id)
        {
            if (_context.Coor == null)
            {
                return NotFound();
            }
            var coor = await _context.Coor.FindAsync(id);

            if (coor == null)
            {
                return NotFound();
            }

            return coor;
        }

        // PUT: api/Coors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoor(string id, Coor coor)
        {
            if (id != coor.Fcskid)
            {
                return BadRequest();
            }

            _context.Entry(coor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoorExists(id))
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

        //// POST: api/Coors
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Coor>> PostCoor(Coor coor)
        //{
        //  if (_context.Coor == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Coor'  is null.");
        //  }
        //    _context.Coor.Add(coor);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (CoorExists(coor.Fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetCoor", new { id = coor.Fcskid }, coor);
        //}

        //// DELETE: api/Coors/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCoor(string id)
        //{
        //    if (_context.Coor == null)
        //    {
        //        return NotFound();
        //    }
        //    var coor = await _context.Coor.FindAsync(id);
        //    if (coor == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Coor.Remove(coor);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool CoorExists(string id)
        {
            return (_context.Coor?.Any(e => e.Fcskid == id)).GetValueOrDefault();
        }
    }
}

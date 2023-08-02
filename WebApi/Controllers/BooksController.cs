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
    public class BooksController : ControllerBase
    {
        private readonly WebApiContext _context;

        public BooksController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBook()
        {
            if (_context.Book == null)
            {
                return NotFound();
            }
            return await _context.Book.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(string? id)
        {
            if (_context.Book == null)
            {
                return NotFound();
            }
            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // GET: api/Books
        [HttpGet("{refType?}/refType")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBookByRefType(string refType)
        {
            if (_context.Book == null)
            {
                return NotFound();
            }
            //return await _context.Book.Where(s => s.fcreftype.fcskid == refType.Trim().ToUpper()).ToListAsync();
            return await _context.Book.ToListAsync();
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(string id, Book book)
        {
            if (id != book.fcskid)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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

        //// POST: api/Books
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Book>> PostBook(Book book)
        //{
        //  if (_context.Book == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Book'  is null.");
        //  }
        //    _context.Book.Add(book);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (BookExists(book.fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetBook", new { id = book.fcskid }, book);
        //}

        //// DELETE: api/Books/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBook(string id)
        //{
        //    if (_context.Book == null)
        //    {
        //        return NotFound();
        //    }
        //    var book = await _context.Book.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Book.Remove(book);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool BookExists(string id)
        {
            return (_context.Book?.Any(e => e.fcskid == id)).GetValueOrDefault();
        }
    }
}

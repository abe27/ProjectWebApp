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
    public class DepartmentsController : ControllerBase
    {
        private readonly WebApiContext _context;

        public DepartmentsController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartment()
        {
            if (_context.Department == null)
            {
                return NotFound();
            }
            return await _context.Department.ToListAsync();
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(string id)
        {
            if (_context.Department == null)
            {
                return NotFound();
            }
            var department = await _context.Department.FindAsync(id);

            if (department == null)
            {
                return NotFound();
            }

            return department;
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(string id, Department department)
        {
            if (id != department.Fcskid)
            {
                return BadRequest();
            }

            _context.Entry(department).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        //// POST: api/Departments
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Department>> PostDepartment(Department department)
        //{
        //  if (_context.Department == null)
        //  {
        //      return Problem("Entity set 'WebApiContext.Department'  is null.");
        //  }
        //    _context.Department.Add(department);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (DepartmentExists(department.Fcskid))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetDepartment", new { id = department.Fcskid }, department);
        //}

        //// DELETE: api/Departments/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDepartment(string id)
        //{
        //    if (_context.Department == null)
        //    {
        //        return NotFound();
        //    }
        //    var department = await _context.Department.FindAsync(id);
        //    if (department == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Department.Remove(department);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool DepartmentExists(string id)
        {
            return (_context.Department?.Any(e => e.Fcskid == id)).GetValueOrDefault();
        }
    }
}

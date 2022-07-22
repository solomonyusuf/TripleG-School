using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripleG.Server.Data;
using TripleG.Server.Models;

namespace TripleG.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class Authentication : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Authentication(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Authentication
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }


        //
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetApplicationUser(string id)
        {

            var applicationUser = await _context.Users.FindAsync(id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            return applicationUser;
        }

        // PUT: api/Authentication/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationUser(Guid id, [FromForm] ApplicationUser applicationUser)
        {
            if (id.ToString() != applicationUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(applicationUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationUserExists(id.ToString()))
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

        // POST: api/Authentication
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicationUser>> PostApplicationUser([FromForm] ApplicationUser applicationUser)
        {
            _context.Users.Add(applicationUser);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ApplicationUserExists(applicationUser.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetApplicationUser", new { id = applicationUser.Id }, applicationUser);
        }

        // DELETE: api/Authentication/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationUser(string id)
        {
            var applicationUser = await _context.Users.FindAsync(id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            _context.Users.Remove(applicationUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicationUserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

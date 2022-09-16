using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using signupApi.Data;
using signupApi.Models;

namespace signupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userlistsController : ControllerBase
    {
        private readonly signupApiContext _context;

        public userlistsController(signupApiContext context)
        {
            _context = context;
        }

        // GET: api/userlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userlist>>> Getuserlist()
        {
          if (_context.userlist == null)
          {
              return NotFound();
          }
            return await _context.userlist.ToListAsync();
        }

        // GET: api/userlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<userlist>> Getuserlist(string id)
        {
          if (_context.userlist == null)
          {
              return NotFound();
          }
            var userlist = await _context.userlist.FindAsync(id);

            if (userlist == null)
            {
                return NotFound();
            }

            return userlist;
        }

        // PUT: api/userlists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuserlist(string id, userlist userlist)
        {
            if (id != userlist.email)
            {
                return BadRequest();
            }

            _context.Entry(userlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userlistExists(id))
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

        // POST: api/userlists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<userlist>> Postuserlist(userlist userlist)
        {
          if (_context.userlist == null)
          {
              return Problem("Entity set 'signupApiContext.userlist'  is null.");
          }
            _context.userlist.Add(userlist);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (userlistExists(userlist.email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getuserlist", new { id = userlist.email }, userlist);
        }

        // DELETE: api/userlists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuserlist(string id)
        {
            if (_context.userlist == null)
            {
                return NotFound();
            }
            var userlist = await _context.userlist.FindAsync(id);
            if (userlist == null)
            {
                return NotFound();
            }

            _context.userlist.Remove(userlist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool userlistExists(string id)
        {
            return (_context.userlist?.Any(e => e.email == id)).GetValueOrDefault();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Projekt.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ProjektContext _context;

        public UsersController(ProjektContext context)

        
        {
            _context = context;

         
        }    

    [Authorize]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AuthUser>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }


// GET api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<AuthUser>> GetUser(int id)
{
    var user =await _context.Users.FindAsync(id);
    if(user == null)
    {
        return NotFound();
    }
    return user;
}
[HttpPost]
public async Task<IActionResult> PostUser (AuthUser item)
{
    _context.Users.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
        public async Task<IActionResult> PutUser(long id, AuthUser item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
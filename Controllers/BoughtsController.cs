using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt;

namespace Projekt.Controllers
{
        
    [Route("api/boughts")]
    [ApiController]
    public class BoughtsController : ControllerBase
    {
        private readonly ProjektContext _context;

        public BoughtsController(ProjektContext context)
        {
            _context = context;

           
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bought>>> GetBoughts()
        {
           return await _context.Boughts
      .Include(w => w.User)
.Include(a=>a.Movie)
   .ToListAsync();
        }


// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Bought>> GetBought(int id)
{
    var bought = await _context.Boughts.FindAsync(id);

    if (bought == null)
    {
        return NotFound();
    }

    return bought;
}
[HttpPost]
public async Task<IActionResult> PostBought(Bought item)
{
    _context.Boughts.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}



[HttpPut("{id}")]
        public async Task<IActionResult> PutBought(long id, Bought item)
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
        public async Task<IActionResult> DeleteBought(int id)
        {
            var bought = await _context.Boughts.FindAsync(id);

            if (bought == null)
            {
                return NotFound();
            }

            _context.Boughts.Remove(bought);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
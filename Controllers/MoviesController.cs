using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Projekt.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ProjektContext _context;

        public MoviesController(ProjektContext context)

        
        {
            _context = context;

         
        }    

    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Models.Movie>>> GetEngagements()
    {
        return await _context.Movies.ToListAsync();
    }


// GET api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Movie>> GetEngagement(int id)
{
    var engagement =await _context.Movies.FindAsync(id);
    if(engagement == null)
    {
        return NotFound();
    }
    return engagement;
}
[HttpPost]
public async Task<IActionResult> PostEngagement (Movie item)
{
    _context.Movies.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
        public async Task<IActionResult> PutEngagement(int id,[FromBody] Movie item)
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
        public async Task<IActionResult> DeleteEngagement(int id)
        {
            var engagement = await _context.Movies.FindAsync(id);

            if (engagement == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(engagement);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Projekt.Controllers
{
    [Route("api/movietype")]
    [ApiController]
    public class MovieTypesController : ControllerBase
    {
        private readonly ProjektContext _context;

        public MovieTypesController(ProjektContext context)

        
        {
            _context = context;

          
        }    

    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieType>>> GetMovieTypes()
    {
        return await _context.MovieTypes.ToListAsync();
    }


// GET api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<MovieType>> GetMovieType(int id)
{
    var movieType =await _context.MovieTypes.FindAsync(id);
    if(movieType == null)
    {
        return NotFound();
    }
    return movieType;
}
[HttpPost]
public async Task<IActionResult> PostMovieType (MovieType item)
{
    _context.MovieTypes.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}
[HttpPut("{id}")]
        public async Task<IActionResult> PutMovieType(long id, MovieType item)
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
        public async Task<IActionResult> DeleteMovieType(int id)
        {
            var movieType = await _context.MovieTypes.FindAsync(id);

            if (movieType == null)
            {
                return NotFound();
            }

            _context.MovieTypes.Remove(movieType);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
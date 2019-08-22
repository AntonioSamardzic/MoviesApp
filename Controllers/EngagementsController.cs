using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Projekt.Models.ViewModel;

namespace Projekt.Controllers
{
    [Route("api/engagements")]
    [ApiController]
    public class EngagementsController : ControllerBase
    {
        private readonly ProjektContext _context;

        public EngagementsController(ProjektContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Engagement>>> GetEngagements()
        {
            return await _context.Engagements
                .Include(w => w.Actor)
                .Include(a => a.Movie)
                .ToListAsync();
        }


        // GET api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Engagement>> GetEngagement(int id)
        {
            var engagement = await _context.Engagements.FindAsync(id);
            if (engagement == null)
            {
                return NotFound();
            }
            return engagement;
        }

        [HttpPost]
        public async Task<IActionResult> PostEngagement(Engagement item)
        {
            _context.Engagements.Add(item);
            await _context.SaveChangesAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Engagement item)
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
            var engagement = await _context.Engagements.FindAsync(id);

            if (engagement == null)
            {
                return NotFound();
            }

            _context.Engagements.Remove(engagement);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
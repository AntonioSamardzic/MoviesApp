using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Projekt.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class ComapaniesController : ControllerBase
    {
        private readonly ProjektContext _context;

        public ComapaniesController(ProjektContext context)

        
        {
            _context = context;

            
        }    

    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Company>>> GetCompany()
    {
        return await _context.Companies.ToListAsync();
    }


// GET api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Company>> GetCompanies(int id)
{
    var company =await _context.Companies.FindAsync(id);
    if(company == null)
    {
        return NotFound();
    }
    return company;
}
[HttpPost]
public async Task<IActionResult> PostCompany (Company item)
{
    _context.Companies.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}
[HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(long id, Company item)
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
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
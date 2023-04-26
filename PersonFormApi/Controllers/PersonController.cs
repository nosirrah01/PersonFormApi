using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PersonFormApi;
using PersonFormApi.Data;

namespace PersonFormApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonDbContext _context;

        public PersonController(PersonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                await _context.SaveChangesAsync();
                return Ok(person);
            }

            return BadRequest(ModelState);
        }
    }
}

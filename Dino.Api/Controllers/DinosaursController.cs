using Dino.Api.Mappers;
using Dino.Api.Models.Data;
using Dino.Api.Models.Data.DbContexts;
using Dino.Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dino.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinosaursController : ControllerBase
    {
        private readonly DinosaurDbContext _dbContext;

        public DinosaursController(DinosaurDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Dinosaurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DinosaurDto>>> GetDinosaurs()
        {
            if (_dbContext.Dinosaurs == null)
            {
                return NotFound();
            }

            return await _dbContext.Dinosaurs.Select(x => x.ToDinosaurDto()).ToListAsync();
        }

        // GET: api/Dinosaurs/2
        [HttpGet("{id}")]
        public async Task<ActionResult<DinosaurDto>> GetDinosaur(int id)
        {
            if (_dbContext.Dinosaurs == null)
            {
                return NotFound();
            }

            var dinosaur = await _dbContext.Dinosaurs.FindAsync(id);

            if (dinosaur == null)
            {
                return NotFound();
            }

            return dinosaur.ToDinosaurDto();
        }

        // POST: api/Dinosaurs
        [HttpPost]
        public async Task<ActionResult<DinosaurDto>> PostDinosaur(Dinosaur dinosaur)
        {
            _dbContext.Dinosaurs.Add(dinosaur);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDinosaur), new { id = dinosaur.Id }, dinosaur.ToDinosaurDto());

            // CreatedAtAction method returns an HTTP 201 status code if successful.
            // HTTP 201 is the standard response for a POST method that creates a new resource on the server.
            // It adds a 'Location' header to the response. The 'Location' header specifies the URI of the newly created record.
            // It configured to reference the 'GetDinosaur' action to create the 'Location' headers URI.
        }

        // PUT: api/Dinosaur/2
        [HttpPut]
        public async Task<IActionResult> PutDinosaur(int id, DinosaurDto dinosaurDto)
        {
            // Update the dinosaur record with the given Id in the database.
            // HTTP specification says PUT requests must send the entire updated entity, not just the changes.

            if (id != dinosaurDto.Id)
            {
                return BadRequest();
            }

            var dinosaur = dinosaurDto.ToDinosaurFromDto();

            _dbContext.Entry(dinosaur).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DinosaurExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // NoContent() returns a 204 (No content).
            return NoContent();
        }

        // DELETE: api/Dinosaur/2
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDinosaur(int id)
        {
            if (_dbContext.Dinosaurs == null)
            {
                return NotFound();
            }

            var dinosaur = await _dbContext.Dinosaurs.FindAsync(id);

            if (dinosaur == null)
            {
                return NotFound();
            }

            _dbContext.Dinosaurs.Remove(dinosaur);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool DinosaurExists(long id)
        {
            return (_dbContext.Dinosaurs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

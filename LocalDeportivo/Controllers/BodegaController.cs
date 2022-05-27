using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalDeportivo.LocalDbContext;
using LocalDeportivo.Models;

namespace LocalDeportivo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodegaController : ControllerBase
    {
        private readonly LocalDeportivoDbContext _context;

        public BodegaController(LocalDeportivoDbContext context)
        {
            _context = context;
        }

        // GET: api/Bodega
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bodega>>> GetBodegas()
        {
            return await _context.Bodegas.ToListAsync();
        }

        // GET: api/Bodega/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bodega>> GetBodega(int id)
        {
            var bodega = await _context.Bodegas.FindAsync(id);

            if (bodega == null)
            {
                return NotFound();
            }

            return bodega;
        }

        // PUT: api/Bodega/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBodega(int id, Bodega bodega)
        {
            if (id != bodega.Id)
            {
                return BadRequest();
            }

            _context.Entry(bodega).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodegaExists(id))
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

        // POST: api/Bodega
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bodega>> PostBodega(Bodega bodega)
        {
            _context.Bodegas.Add(bodega);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBodega", new { id = bodega.Id }, bodega);
        }

        // DELETE: api/Bodega/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBodega(int id)
        {
            var bodega = await _context.Bodegas.FindAsync(id);
            if (bodega == null)
            {
                return NotFound();
            }

            _context.Bodegas.Remove(bodega);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BodegaExists(int id)
        {
            return _context.Bodegas.Any(e => e.Id == id);
        }
    }
}

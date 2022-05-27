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
    public class EntradaSalidaController : ControllerBase
    {
        private readonly LocalDeportivoDbContext _context;

        public EntradaSalidaController(LocalDeportivoDbContext context)
        {
            _context = context;
        }

        // GET: api/EntradaSalida
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntradaSalida>>> GetEntradaSalidas()
        {
            return await _context.EntradaSalidas.ToListAsync();
        }

        // GET: api/EntradaSalida/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntradaSalida>> GetEntradaSalida(int id)
        {
            var entradaSalida = await _context.EntradaSalidas.FindAsync(id);

            if (entradaSalida == null)
            {
                return NotFound();
            }

            return entradaSalida;
        }

        // PUT: api/EntradaSalida/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntradaSalida(int id, EntradaSalida entradaSalida)
        {
            if (id != entradaSalida.CodigoEntradaSalida)
            {
                return BadRequest();
            }

            _context.Entry(entradaSalida).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntradaSalidaExists(id))
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

        // POST: api/EntradaSalida
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EntradaSalida>> PostEntradaSalida(EntradaSalida entradaSalida)
        {
            _context.EntradaSalidas.Add(entradaSalida);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntradaSalida", new { id = entradaSalida.CodigoEntradaSalida }, entradaSalida);
        }

        // DELETE: api/EntradaSalida/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntradaSalida(int id)
        {
            var entradaSalida = await _context.EntradaSalidas.FindAsync(id);
            if (entradaSalida == null)
            {
                return NotFound();
            }

            _context.EntradaSalidas.Remove(entradaSalida);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntradaSalidaExists(int id)
        {
            return _context.EntradaSalidas.Any(e => e.CodigoEntradaSalida == id);
        }
    }
}

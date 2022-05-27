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
    public class DetalleFacturaController : ControllerBase
    {
        private readonly LocalDeportivoDbContext _context;

        public DetalleFacturaController(LocalDeportivoDbContext context)
        {
            _context = context;
        }

        // GET: api/DetalleFactura
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleFactura>>> GetDetalleFacturas()
        {
            return await _context.DetalleFacturas.ToListAsync();
        }

        // GET: api/DetalleFactura/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleFactura>> GetDetalleFactura(int id)
        {
            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);

            if (detalleFactura == null)
            {
                return NotFound();
            }

            return detalleFactura;
        }

        // PUT: api/DetalleFactura/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleFactura(int id, DetalleFactura detalleFactura)
        {
            if (id != detalleFactura.CodigoDetalleFactura)
            {
                return BadRequest();
            }

            _context.Entry(detalleFactura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleFacturaExists(id))
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

        // POST: api/DetalleFactura
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleFactura>> PostDetalleFactura(DetalleFactura detalleFactura)
        {
            _context.DetalleFacturas.Add(detalleFactura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleFactura", new { id = detalleFactura.CodigoDetalleFactura }, detalleFactura);
        }

        // DELETE: api/DetalleFactura/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleFactura(int id)
        {
            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);
            if (detalleFactura == null)
            {
                return NotFound();
            }

            _context.DetalleFacturas.Remove(detalleFactura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleFacturaExists(int id)
        {
            return _context.DetalleFacturas.Any(e => e.CodigoDetalleFactura == id);
        }
    }
}

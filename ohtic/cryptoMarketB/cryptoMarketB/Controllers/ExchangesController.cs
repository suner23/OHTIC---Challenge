using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cryptoMarketB.Data;
using cryptoMarketB.Models;

namespace cryptoMarketB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangesController : ControllerBase
    {
        private readonly cryptoMarketBContext _context;

        public ExchangesController(cryptoMarketBContext context)
        {
            _context = context;
        }

        // GET: api/Exchanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exchange>>> GetExchange()
        {
            return await _context.Exchange.ToListAsync();
        }

        // GET: api/Exchanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exchange>> GetExchange(int id)
        {
            var exchange = await _context.Exchange.FindAsync(id);

            if (exchange == null)
            {
                return NotFound();
            }

            return exchange;
        }

        // PUT: api/Exchanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExchange(int id, Exchange exchange)
        {
            if (id != exchange.Id)
            {
                return BadRequest();
            }

            _context.Entry(exchange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExchangeExists(id))
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

        // POST: api/Exchanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Exchange>> PostExchange(Exchange exchange)
        {
            _context.Exchange.Add(exchange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExchange", new { id = exchange.Id }, exchange);
        }

        // DELETE: api/Exchanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Exchange>> DeleteExchange(int id)
        {
            var exchange = await _context.Exchange.FindAsync(id);
            if (exchange == null)
            {
                return NotFound();
            }

            _context.Exchange.Remove(exchange);
            await _context.SaveChangesAsync();

            return exchange;
        }

        private bool ExchangeExists(int id)
        {
            return _context.Exchange.Any(e => e.Id == id);
        }
    }
}

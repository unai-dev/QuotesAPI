using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuotesAPI.Data;
using QuotesAPI.DTOs;
using QuotesAPI.Models;

namespace QuotesAPI.Controllers
{
    [ApiController]
    [Route("quotes")]
    public class QuotesController: ControllerBase
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;

        public QuotesController(AppDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? category)
        {
            var query = db.Quotes.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                query = query.Where(c => c.Category == category);
            }

            return Ok(await query.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var quote = await db.Quotes.FindAsync(id);
            return quote is null ? NotFound() : Ok(quote);
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandom([FromQuery] string? category)
        {
            var query = db.Quotes.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                query = query.Where(c => c.Category == category);
            }

            var count = await query.CountAsync();

            if (count == 0) return NotFound("No hay frases en la categoria indicada");

            /**
             * 1. Saltamos los elementos en el numero generado aleatoriamente
             * 2. Devolvemos el primero de todos los elementos obtenidos
             */
            var quote = await query.Skip(Random.Shared.Next(count)).FirstAsync();
            return Ok(quote);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateQuoteDTO quoteDTO)
        {
            var quote = mapper.Map<Quote>(quoteDTO);

            quote.CreatedAt = DateTime.UtcNow;
            db.Add(quote);
            await db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = quote.Id }, quote);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var quote = await db.Quotes.FindAsync(id);
            if (quote is null) return NotFound();

            db.Quotes.Remove(quote);
            await db.SaveChangesAsync();

            return NoContent();
        }
    }
}

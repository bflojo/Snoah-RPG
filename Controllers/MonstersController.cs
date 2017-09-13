using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnoahRpg.Model;

namespace SnoahRpg.Controllers
{
    [Produces("application/json")]
    [Route("api/Monsters")]
    public class MonstersController : Controller
    {
        private readonly SnoahRpgContext _context;

        public MonstersController(SnoahRpgContext context)
        {
            _context = context;
        }

        // GET: api/Monsters
        [HttpGet]
        public IEnumerable<Monster> GetMonster()
        {
            return _context.Monster;
        }

        // GET: api/Monsters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMonster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monster = await _context.Monster.SingleOrDefaultAsync(m => m.Id == id);

            if (monster == null)
            {
                return NotFound();
            }

            return Ok(monster);
        }

        // PUT: api/Monsters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonster([FromRoute] int id, [FromBody] Monster monster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monster.Id)
            {
                return BadRequest();
            }

            _context.Entry(monster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterExists(id))
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

        // POST: api/Monsters
        [HttpPost]
        public async Task<IActionResult> PostMonster([FromBody] Monster monster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Monster.Add(monster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonster", new { id = monster.Id }, monster);
        }

        // DELETE: api/Monsters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monster = await _context.Monster.SingleOrDefaultAsync(m => m.Id == id);
            if (monster == null)
            {
                return NotFound();
            }

            _context.Monster.Remove(monster);
            await _context.SaveChangesAsync();

            return Ok(monster);
        }

        private bool MonsterExists(int id)
        {
            return _context.Monster.Any(e => e.Id == id);
        }
    }
}
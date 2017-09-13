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
    [Route("api/Items")]
    public class ItemsController : Controller
    {
        private readonly SnoahRpgContext _context;

        public ItemsController(SnoahRpgContext context)
        {
            _context = context;
            if (_context.Item.Count() == 0)
            {

                Item h1 = new Item
                {
                    Id = 1,
                    Name = "Leather Cap",
                    Power = 25,
                    Type = "head"
                };

                Item h2 = new Item
                {
                    Id = 1,
                    Name = "Chain Helm",
                    Power = 50,
                    Type = "head"
                };


                Item h3 = new Item
                {
                    Id = 1,
                    Name = "Plate Helm",
                    Power = 25,
                    Type = "head"

                };

                Item c1 = new Item
                {
                    Id = 1,
                    Name = "Quilted armor",
                    Power = 100,
                    Type = "chest"
                };


                Item c2 = new Item
                {
                    Id = 1,
                    Name = "Studed Armor",
                    Power = 150,
                    Type = "chest"
                };


                Item c3 = new Item
                {
                    Id = 1,
                    Name = "Chainmail Armor",
                    Power = 200,
                    Type = "chest"
                };


                Item c4 = new Item
                {
                    Id = 1,
                    Name = "Plate Armor",
                    Power = 300,
                    Type = "chest"
                };


                Item w1 = new Item
                {
                    Id = 1,
                    Name = "Leather Bracers",
                    Power = 20,
                    Type = "wrist"
                };


                Item e3 = new Item
                {
                    Id = 1,
                    Name = "Bands of Sweat Power",
                    Power = 2,
                    Type = "unique"
                };


                Item d1 = new Item
                {
                    Id = 1,
                    Name = "Rusty Dagger",
                    Power = 25,
                    Type = "weapon"
                };


                Item d2 = new Item
                {
                    Id = 1,
                    Name = "Dual Daggers",
                    Power = 50,
                    Type = "weapon"
                };


                Item d3 = new Item
                {
                    Id = 1,
                    Name = "Dragon Dagger",
                    Power = 90,
                    Type = "weapon"
                };


                Item s1 = new Item
                {
                    Id = 1,
                    Name = "wooden sword",
                    Power = 15,
                    Type = "weapon"
                };



                Item s2 = new Item
                {
                    Id = 1,
                    Name = "Rusty sword",
                    Power = 35,
                    Type = "weapon"
                };


                Item s3 = new Item
                {
                    Id = 1,
                    Name = "Long Sword",
                    Power = 60,
                    Type = "weapon"
                };


                Item s4 = new Item
                {
                    Id = 1,
                    Name = "Epic Sword",
                    Power = 150,
                    Type = "weapon"
                };


                Item m1 = new Item
                {
                    Id = 1,
                    Name = "Morningstar",
                    Power = 45,
                    Type = "weapon"
                };


                Item m2 = new Item
                {
                    Id = 1,
                    Name = "Long Sword",
                    Power = 60,
                    Type = "weapon"
                };


                Item m3 = new Item
                {
                    Id = 1,
                    Name = "Warhammer",
                    Power = 80,
                    Type = "weapon"
                };


                Item m4 = new Item
                {
                    Id = 1,
                    Name = "Maul",
                    Power = 120,
                    Type = "weapon"
                };


                Item a1 = new Item
                {
                    Id = 1,
                    Name = "Fairy Wand",
                    Power = 15,
                    Type = "weapon"
                };

                Item a2 = new Item
                {
                    Id = 1,
                    Name = "Ice Wand",
                    Power = 60,
                    Type = "weapon"
                };


                Item a3 = new Item
                {
                    Id = 1,
                    Name = "Explosive Staff",
                    Power = 500,
                    Type = "weapon"
                };


                Item e1 = new Item
                {
                    Id = 1,
                    Name = "Epic Paddle Of Legend",
                    Power = 999,
                    Type = "unique"
                };


                Item e2 = new Item
                {
                    Id = 1,
                    Name = "Golden Ball of Speed",
                    Power = 999,
                    Type = "unique"
                };


                Item l1 = new Item
                {
                    Id = 1,
                    Name = "Weak Healing Pot",
                    Power = 25,
                    Type = "heal"
                };


                Item l2 = new Item
                {
                    Id = 1,
                    Name = "Strong Health Pot",
                    Power = 60,
                    Type = "heal"
                };


                Item l3 = new Item
                {
                    Id = 1,
                    Name = "Full Health Pot",
                    Power = 100,
                    Type = "heal"
                };
            }

        // GET: api/Items
        [HttpGet]
        public IEnumerable<Item> GetItem()
        {
            return _context.Item;
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = await _context.Item.SingleOrDefaultAsync(m => m.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem([FromRoute] int id, [FromBody] Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
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

        // POST: api/Items
        [HttpPost]
        public async Task<IActionResult> PostItem([FromBody] Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Item.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = await _context.Item.SingleOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Item.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(item);
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.Id == id);
        }
    }
}
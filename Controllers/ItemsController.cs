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
                    Type = "head",
                    Image = "https://imgur.com/B8ISUAu"
                };

                Item h2 = new Item
                {
                    Id = 2,
                    Name = "Chain Helm",
                    Power = 50,
                    Type = "head",
                    Image = "https://imgur.com/76AQtlL"
                };


                Item h3 = new Item
                {
                    Id = 3,
                    Name = "Plate Helm",
                    Power = 25,
                    Type = "head",
                    Image = "https://imgur.com/omtahia"

                };

                Item c1 = new Item
                {
                    Id = 4,
                    Name = "Quilted armor",
                    Power = 100,
                    Type = "chest",
                    Image = "https://imgur.com/dpsPcKY"
                };


                Item c2 = new Item
                {
                    Id = 5,
                    Name = "Studed Armor",
                    Power = 150,
                    Type = "chest",
                    Image = "https://imgur.com/p4Ej6Vy"
                };


                Item c3 = new Item
                {
                    Id = 6,
                    Name = "Chainmail Armor",
                    Power = 200,
                    Type = "chest",
                    Image = "https://imgur.com/lroGpF6"
                };


                Item c4 = new Item
                {
                    Id = 7,
                    Name = "Plate Armor",
                    Power = 300,
                    Type = "chest",
                    Image = "https://imgur.com/qJ6IFu5"
                };


                Item w1 = new Item
                {
                    Id = 8,
                    Name = "Leather Bracers",
                    Power = 20,
                    Type = "wrist",
                    Image = "https://imgur.com/xqJIVeH"
                };


                Item e3 = new Item
                {
                    Id = 9,
                    Name = "Bands of Sweat Protection",
                    Power = 2,
                    Type = "unique",
                    Image = "https://imgur.com/Y6CrlfY"
                };


                Item d1 = new Item
                {
                    Id = 10,
                    Name = "Rusty Dagger",
                    Power = 25,
                    Type = "weapon",
                    Image = "https://imgur.com/6SKUvJJ"
                };


                Item d2 = new Item
                {
                    Id = 11,
                    Name = "Dual Daggers",
                    Power = 50,
                    Type = "weapon",
                    Image = "https://imgur.com/nusUMRH"
                };


                Item d3 = new Item
                {
                    Id = 12,
                    Name = "Dragon Dagger",
                    Power = 90,
                    Type = "weapon",
                    Image = "https://imgur.com/PtqULrc"
                };


                Item s1 = new Item
                {
                    Id = 13,
                    Name = "wooden sword",
                    Power = 15,
                    Type = "weapon",
                    Image = "https://imgur.com/YStzpVp"
                };



                Item s2 = new Item
                {
                    Id = 14,
                    Name = "Rusty sword",
                    Power = 35,
                    Type = "weapon",
                    Image = "https://imgur.com/c4HbG01"
                };


                Item s3 = new Item
                {
                    Id = 15,
                    Name = "Long Sword",
                    Power = 60,
                    Type = "weapon",
                    Image = "https://imgur.com/gZbFzR7"
                };


                Item s4 = new Item
                {
                    Id = 16,
                    Name = "Epic Sword",
                    Power = 150,
                    Type = "weapon",
                    Image = "https://imgur.com/0wRqAkq"
                };


                Item m1 = new Item
                {
                    Id = 17,
                    Name = "Morningstar",
                    Power = 45,
                    Type = "weapon",
                    Image = "https://imgur.com/Bkkg8Oi"
                };


                Item m2 = new Item
                {
                    Id = 18,
                    Name = "Warhammer",
                    Power = 80,
                    Type = "weapon",
                    Image = "https://imgur.com/XTUJ0MO"
                };


                Item m3 = new Item
                {
                    Id = 19,
                    Name = "Maul",
                    Power = 120,
                    Type = "weapon",
                    Image = "https://imgur.com/g4M8vqu"
                };


                Item a1 = new Item
                {
                    Id = 20,
                    Name = "Fire Wand",
                    Power = 15,
                    Type = "weapon",
                    Image = "https://imgur.com/T6nP8q4"
                };

                Item a2 = new Item
                {
                    Id = 21,
                    Name = "Ice Wand",
                    Power = 60,
                    Type = "weapon",
                    Image = "https://imgur.com/z1GnCeA"
                };


                Item a3 = new Item
                {
                    Id = 22,
                    Name = "Explosive Staff",
                    Power = 500,
                    Type = "weapon",
                    Image = "https://imgur.com/mVFZVTN"
                };


                Item e1 = new Item
                {
                    Id = 23,
                    Name = "Golden Paddle",
                    Power = 999,
                    Type = "unique",
                    Image = "https://imgur.com/sSC30Sf"
                };


                Item e2 = new Item
                {
                    Id = 24,
                    Name = "Golden Ball",
                    Power = 999,
                    Type = "unique",
                    Image = "https://imgur.com/3Dn1nK4"
                };


                Item l1 = new Item
                {
                    Id = 25,
                    Name = "Weak Healing Pot",
                    Power = 25,
                    Type = "heal",
                    Image = "https://imgur.com/Shv8V3e"
                };


                Item l2 = new Item
                {
                    Id = 26,
                    Name = "Strong Health Pot",
                    Power = 60,
                    Type = "heal",
                    Image = "https://imgur.com/PMeJsVL"
                };


                Item l3 = new Item
                {
                    Id = 27,
                    Name = "Full Health Pot",
                    Power = 100,
                    Type = "heal",
                    Image = "https://imgur.com/Rz2mBfm"
                };
        }
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
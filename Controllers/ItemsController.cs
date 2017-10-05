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

                Item h1 = new Item();
                {
                    h1.Id = 1;
                    h1.Name = "Leather Cap";
                    h1.Power = 5;
                    h1.Type = "helmet";
                    h1.Image = "https://i.imgur.com/tFG1KOM.png";
                };
                _context.Item.Add(h1);
                _context.SaveChanges();

                Item h2 = new Item();
                {
                    h2.Id = 2;
                    h2.Name = "Chainmail Helm";
                    h2.Power = 10;
                    h2.Type = "helmet";
                    h2.Image = "https://i.imgur.com/G3rbn1J.png";
                };
                _context.Item.Add(h2);
                _context.SaveChanges();

                Item h3 = new Item();
                {
                    h3.Id = 3;
                    h3.Name = "Plate Helm";
                    h3.Power = 20;
                    h3.Type = "helmet";
                    h3.Image = "https://i.imgur.com/MSLjTpx.png";

                };
                _context.Item.Add(h3);
                _context.SaveChanges();

                Item a1 = new Item();
                {
                    a1.Id = 4;
                    a1.Name = "Studed Leather Armor";
                    a1.Power = 10;
                    a1.Type = "chest";
                    a1.Image = "https://i.imgur.com/QcXVP0b.png";
                };
                _context.Item.Add(a1);
                _context.SaveChanges();

                Item a2 = new Item();
                {
                    a2.Id = 5;
                    a2.Name = "Quilted armor";
                    a2.Power = 15;
                    a2.Type = "chest";
                    a2.Image = "https://i.imgur.com/9oadoje.png";
                };

                _context.Item.Add(a2);
                _context.SaveChanges();

                Item a3 = new Item();
                {
                    a3.Id = 6;
                    a3.Name = "Chainmail Armor";
                    a3.Power = 20;
                    a3.Type = "chest";
                    a3.Image = "https://i.imgur.com/uuDawKP.png";
                };
                _context.Item.Add(a3);
                _context.SaveChanges();

                Item a4 = new Item();
                {
                    a4.Id = 7;
                    a4.Name = "Plate Armor";
                    a4.Power = 25;
                    a4.Type = "chest";
                    a4.Image = "https://i.imgur.com/ilIaLPc.png";
                };
                _context.Item.Add(a4);
                _context.SaveChanges();

                Item a5 = new Item();
                {
                    a5.Id = 8;
                    a5.Name = "Leather Bracers";
                    a5.Power = 5;
                    a5.Type = "wrist";
                    a5.Image = "https://i.imgur.com/iAdsqt0.png";
                };
                _context.Item.Add(a5);
                _context.SaveChanges();

                Item w1 = new Item();
                {
                    w1.Id = 9;
                    w1.Name = "Maul";
                    w1.Power = 60;
                    w1.Type = "weapon";
                    w1.Image = "https://i.imgur.com/hXAEbM1.png";
                };
                _context.Item.Add(w1);
                _context.SaveChanges();

                Item w2 = new Item();
                {
                    w2.Id = 10;
                    w2.Name = "Morning Star";
                    w2.Power = 20;
                    w2.Type = "weapon";
                    w2.Image = "https://i.imgur.com/47MXsHr.png";
                };
                _context.Item.Add(w2);
                _context.SaveChanges();

                Item w3 = new Item();
                {
                    w3.Id = 11;
                    w3.Name = "War Hammer";
                    w3.Power = 40;
                    w3.Type = "weapon";
                    w3.Image = "https://i.imgur.com/nNjnfMu.png";
                };
                _context.Item.Add(w3);
                _context.SaveChanges();

                Item w4 = new Item();
                {
                    w4.Id = 12;
                    w4.Name = "Rusty Sword";
                    w4.Power = 10;
                    w4.Type = "weapon";
                    w4.Image = "https://i.imgur.com/LARZT7I.png";
                };
                _context.Item.Add(w4);
                _context.SaveChanges();

                Item w5 = new Item();
                {
                    w5.Id = 13;
                    w5.Name = "wooden sword";
                    w5.Power = 7;
                    w5.Type = "weapon";
                    w5.Image = "https://i.imgur.com/B6Ul0mf.jpg";
                };
                _context.Item.Add(w5);
                _context.SaveChanges();

                Item w6 = new Item();
                {
                    w6.Id = 14;
                    w6.Name = "Long Sword";
                    w6.Power = 30;
                    w6.Type = "weapon";
                    w6.Image = "https://i.imgur.com/qFl4976.png";
                };
                _context.Item.Add(w6);
                _context.SaveChanges();

                Item w7 = new Item();
                {
                    w7.Id = 15;
                    w7.Name = "EPIC Sword";
                    w7.Power = 70;
                    w7.Type = "weapon";
                    w7.Image = "https://i.imgur.com/poj0jfC.png";
                };
                _context.Item.Add(w7);
                _context.SaveChanges();

                Item w8 = new Item();
                {
                    w8.Id = 16;
                    w8.Name = "Rusty Daggers";
                    w8.Power = 10;
                    w8.Type = "weapon";
                    w8.Image = "https://i.imgur.com/50DTMnJ.png";
                };
                _context.Item.Add(w8);
                _context.SaveChanges();

                Item w9 = new Item();            
                {
                    w9.Id = 17;
                    w9.Name = "Twin Daggers";
                    w9.Power = 25;
                    w9.Type = "weapon";
                    w9.Image = "https://i.imgur.com/1BCiVsW.png";

                };
                _context.Item.Add(w9);
                _context.SaveChanges();

                Item w10 = new Item();
                {
                    w10.Id = 18;
                    w10.Name = "Dragon Dagger";
                    w10.Power = 50;
                    w10.Type = "weapon";
                    w10.Image = "https://i.imgur.com/kwPiOCK.png";

                };
                _context.Item.Add(w10);
                _context.SaveChanges();

                Item w11 = new Item();
                {
                    w11.Id = 19;
                    w11.Name = "Explosive Staff";
                    w11.Power = 60;
                    w11.Type = "weapon";
                    w11.Image = "https://i.imgur.com/u0JVNz2.png";
                };
                _context.Item.Add(w11);
                _context.SaveChanges();

                Item w12 = new Item();
                {
                    w12.Id = 20;
                    w12.Name = "Fire Wand";
                    w12.Power = 35;
                    w12.Type = "weapon";
                    w12.Image = "https://i.imgur.com/Hx5cg5S.png";
                };
                _context.Item.Add(w12);
                _context.SaveChanges();

                Item w13 = new Item();
                {
                    w13.Id = 21;
                    w13.Name = "Ice Wand";
                    w13.Power = 40;
                    w13.Type = "weapon";
                    w13.Image = "https://i.imgur.com/Do8tVyQ.png";
                };
                _context.Item.Add(w13);
                _context.SaveChanges();

                Item o1 = new Item();
                {
                    o1.Id = 22;
                    o1.Name = "Golden Ball";
                    o1.Power = 0;
                    o1.Type = "other";
                    o1.Image = "https://i.imgur.com/RvJZNk9.jpg";
                };
                _context.Item.Add(o1);
                _context.SaveChanges();

                Item o2 = new Item();
                {
                    o2.Id = 23;
                    o2.Name = "Golden Paddle";
                    o2.Power = 0;
                    o2.Type = "other";
                    o2.Image = "https://i.imgur.com/feoJp0d.png";
                };
                _context.Item.Add(o2);
                _context.SaveChanges();

                Item o3 = new Item();
                {
                    o3.Id = 24;
                    o3.Name = "Golden Sweat Bands";
                    o3.Power = 0;
                    o3.Type = "other";
                    o3.Image = "https://i.imgur.com/x28nL5x.png";
                };
                _context.Item.Add(o3);
                _context.SaveChanges();

                Item o4 = new Item();
                {
                    o4.Id = 25;
                    o4.Name = "Small Potion";
                    o4.Power = 50;
                    o4.Type = "heal";
                    o4.Image = "https://i.imgur.com/EmmAL5V.png";
                };
                _context.Item.Add(o4);
                _context.SaveChanges();

                Item o5 = new Item();
                {
                    o5.Id = 26;
                    o5.Name = "Medium Potion";
                    o5.Power = 100;
                    o5.Type = "heal";
                    o5.Image = "https://i.imgur.com/qDkCEFe.png";
                };
                _context.Item.Add(o5);
                _context.SaveChanges();

                Item o6 = new Item();
                {
                    o6.Id = 27;
                    o6.Name = "Large Potion";
                    o6.Power = 200;
                    o6.Type = "heal";
                    o6.Image = "https://i.imgur.com/DdBNUSi.png";
                };
                _context.Item.Add(o6);
                _context.SaveChanges();
                
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
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
    [Route("api/Players")]
    public class PlayersController : Controller
    {
        private readonly SnoahRpgContext _context;

        public PlayersController(SnoahRpgContext context)
        {
            _context = context;
            if (_context.Player.Count() == 0)
            {
                Player p1 = new Player();
                {
                    p1.Id = 1;
                    p1.Name = "Link";
                    p1.MaxHealth = 100;
                    p1.CurrentHealth = 100;
                    p1.Power = 10;
                    p1.Backpack = new List<Item>
                    {
                    new Item
                    {
                        Id = 25648,
                        Name = "Small Potion",
                        Power = 50,
                        Type = "heal",
                        Image = "https://i.imgur.com/EmmAL5V.png"
                    },
                    new Item
                    {
                        Id = 2536459,
                        Name = "Small Potion",
                        Power = 50,
                        Type = "heal",
                        Image = "https://i.imgur.com/EmmAL5V.png"
                    },
                    new Item
                    {
                        Id = 13234,
                        Name = "Wooden Sword",
                        Power = 7,
                        Type = "weapon",
                        Image = "https://i.imgur.com/B6Ul0mf.jpg"
                    }
                    };
                    p1.CurrentLocation = new Location
                    {
                        Id = 1321,
                        Name = "Forest 1",
                        Image = "https://i.imgur.com/T1gdOrD.jpg"
                    };
                    p1.CurrentHelmet = new Item
                    {
                        Id = 101,
                        Name = "None",
                        Power = 0,
                        Type = "helmet"
                    };
                    p1.CurrentChest = new Item
                    {
                        Id = 102,
                        Name = "Shirt",
                        Power = 0,
                        Type = "chest"
                    };
                    p1.CurrentWrist = new Item
                    {
                        Id = 103,
                        Name = "None",
                        Power = 0,
                        Type = "wrist"
                    };
                    p1.CurrentWeapon = new Item
                    {
                        Id = 104,
                        Name = "Fists",
                        Power = 0,
                        Type = "weapon"
                    };
                    _context.Player.Add(p1);
                    _context.SaveChangesAsync();
                };
               
           }
        }

        // GET: api/Players
        [HttpGet]
        public IEnumerable<Player> GetPlayer()
        {
            return _context.Player;
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var player = await _context.Player.SingleOrDefaultAsync(m => m.Id == id);

            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer([FromRoute] int id, [FromBody] Player player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != player.Id)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
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

        // POST: api/Players
        [HttpPost]
        public async Task<IActionResult> PostPlayer([FromBody] Player player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Player.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayer", new { id = player.Id }, player);
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var player = await _context.Player.SingleOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Player.Remove(player);
            await _context.SaveChangesAsync();

            return Ok(player);
        }

        private bool PlayerExists(int id)
        {
            return _context.Player.Any(e => e.Id == id);
        }
    }
}
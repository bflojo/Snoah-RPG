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
            if (_context.Monster.Count() == 0)
            {
                Monster m1 = new Monster();
                {
                    m1.Id = 1;
                    m1.Name = "Goblin";
                    m1.Health = 50;
                    m1.Power = 10;
                    m1.Image = "https://i.imgur.com/eglQMzm.png";
                    m1.CurrentChest = new Item
                    {
                        Id = 400,
                        Name = "Chainmail Helm",
                        Power = 10,
                        Type = "helmet",
                        Image = "https://i.imgur.com/gyIHymO.png",
                    };
                    m1.CurrentWrist = new Item
                    {
                        Id = 800,
                        Name = "Leather Bracers",
                        Power = 5,
                        Type = "wrists",
                        Image = "https://i.imgur.com/iAdsqt0.png"
                    };
                    m1.CurrentWeapon = new Item
                    {
                        Id = 1300,
                        Name = "Wooden Sword",
                        Power = 7,
                        Type = "weapon",
                        Image = "https://i.imgur.com/B6Ul0mf.jpg"
                    };
                };
                _context.Monster.Add(m1);
                _context.SaveChanges();
                Monster m2 = new Monster();
                {
                    m2.Id = 2;
                    m2.Name = "Ork";
                    m2.Health = 100;
                    m2.Power = 10;
                    m2.Image = "https://i.imgur.com/PYGVUix.png";
                    m2.CurrentHelmet = new Item
                    {
                        Id = 200,
                        Name = "Chainmail Helm",
                        Power = 10,
                        Type = "helmet",
                        Image = "https://i.imgur.com/G3rbn1J.png"
                    };
                    m2.CurrentChest = new Item
                    {
                        Id = 600,
                        Name = "Chainmail Armor",
                        Power = 20,
                        Type = "chest",
                        Image = "https://i.imgur.com/uuDawKP.png"
                    };
                    m2.CurrentWrist = new Item
                    {
                        Id = 601,
                        Name = "Iron Bracers",
                        Power = 6,
                        Type = "wrist"
                    };
                    m2.CurrentWeapon = new Item
                    {
                        Id = 1000,
                        Name = "Morning Star",
                        Power = 20,
                        Type = "weapon",
                        Image = "https://i.imgur.com/47MXsHr.png"
                    };
                };
                _context.Monster.Add(m2);
                _context.SaveChanges();
                Monster m3 = new Monster();
                {
                    m3.Id = 3;
                    m3.Name = "Bear";
                    m3.Health = 75;
                    m3.Power = 15;
                    m3.Image = "https://i.imgur.com/9BpFkIX.png";
                    m3.CurrentHelmet = null;
                    m3.CurrentChest = null;
                    m3.CurrentWrist = null;
                    m3.CurrentWeapon = null;
                };
                _context.Monster.Add(m3);
                _context.SaveChanges();
                Monster m4 = new Monster();
                {
                    m4.Id = 4;
                    m4.Name = "Cactus Patch Kid";
                    m4.Health = 50;
                    m4.Power = 20;
                    m4.Image = "https://i.imgur.com/qKEAK4k.jpg";
                    m4.CurrentHelmet = null;
                    m4.CurrentChest = null;
                    m4.CurrentWrist = null;
                    m4.CurrentWeapon = null;
                };
                _context.Monster.Add(m4);
                _context.SaveChanges();
                Monster m5 = new Monster();
                {
                    m5.Id = 5;
                    m5.Name = "Desert Yeti";
                    m5.Health = 100;
                    m5.Power = 10;
                    m5.Image = "https://i.imgur.com/O9AH2iE.png";
                    m5.CurrentHelmet = null;
                    m5.CurrentChest = null;
                    m5.CurrentWrist = null;
                    m5.CurrentWeapon = null;
                };
                _context.Monster.Add(m5);
                _context.SaveChanges();
                Monster m6 = new Monster();
                {
                    m6.Id = 6;
                    m6.Name = "Evil Hotdog";
                    m6.Health = 200;
                    m6.Power = 20;
                    m6.Image = "https://i.imgur.com/vRWj8Yt.png";
                    m6.CurrentHelmet = null;
                    m6.CurrentChest = null;
                    m6.CurrentWrist = null;
                    m6.CurrentWeapon = null;
                };
                _context.Monster.Add(m6);
                _context.SaveChanges();
                Monster m7 = new Monster();
                {
                    m7.Id = 7;
                    m7.Name = "Evil Knight";
                    m7.Health = 150;
                    m7.Power = 30;
                    m7.Image = "https://i.imgur.com/UlqCtjh.png";
                    m7.CurrentHelmet = new Item
                    {
                        Id = 301,
                        Name = "Plate Helm",
                        Power = 20,
                        Type = "helmet",
                        Image = "https://i.imgur.com/MSLjTpx.png",
                    };
                    m7.CurrentChest = new Item
                    {
                        Id = 700,
                        Name = "Plate Armor",
                        Power = 25,
                        Type = "chest",
                        Image = "https://i.imgur.com/ilIaLPc.png"
                    };
                    m7.CurrentWrist = new Item
                    {
                        Id = 602,
                        Name = "Iron Bracers",
                        Power = 6,
                        Type = "wrist"
                    };
                    m7.CurrentWeapon = new Item
                    {
                        Id = 1400,
                        Name = "Long Sword",
                        Power = 30,
                        Type = "weapon",
                        Image = "https://i.imgur.com/qFl4976.png"
                    };
                };
                _context.Monster.Add(m7);
                _context.SaveChanges();
                Monster m8 = new Monster();
                {
                    m8.Id = 8;
                    m8.Name = "Dark Mage";
                    m8.Health = 100;
                    m8.Power = 25;
                    m8.Image = "https://i.imgur.com/i7gpSkr.png";
                    m8.CurrentHelmet = null;
                    m8.CurrentChest = new Item
                    {
                        Id = 500,
                        Name = "Quilted Armor",
                        Power = 15,
                        Type = "chest",
                        Image = "https://i.imgur.com/9oadoje.png"
                    };
                    m8.CurrentWrist = null;
                    m8.CurrentWeapon = new Item
                    {
                        Id = 2000,
                        Name = "Fire Wand",
                        Power = 35,
                        Type = "weapon",
                        Image = "https://i.imgur.com/Hx5cg5S.png"
                    };
                };
                _context.Monster.Add(m8);
                _context.SaveChanges();
                Monster m9 = new Monster();
                {
                    m9.Id = 9;
                    m9.Name = "Frozen Banshee";
                    m9.Health = 150;
                    m9.Power = 20;
                    m9.Image = "https://i.imgur.com/7z1Ovo2.png";
                    m9.CurrentHelmet = null;
                    m9.CurrentChest = null;
                    m9.CurrentWrist = null;
                    m9.CurrentWeapon = new Item
                    {
                        Id = 2100,
                        Name = "Ice Wand",
                        Power = 40,
                        Type = "weapon",
                        Image = "https://i.imgur.com/Do8tVyQ.png"
                    };
                };
                _context.Monster.Add(m9);
                _context.SaveChanges();
                Monster m10 = new Monster();
                {
                    m10.Name = "Frost Troll";
                    m10.Health = 100;
                    m10.Id = 10;
                    m10.Power = 12;
                    m10.Image = "https://i.imgur.com/p3esL4H.jpg";
                    m10.CurrentHelmet = new Item
                    {
                        Id = 204,
                        Name = "Chainmail Helm",
                        Power = 10,
                        Type = "helmet",
                        Image = "https://i.imgur.com/G3rbn1J.png"
                    };
                    m10.CurrentChest = new Item
                    {
                        Id = 607,
                        Name = "Chainmail Armor",
                        Power = 20,
                        Type = "chest",
                        Image = "https://i.imgur.com/uuDawKP.png"
                    };
                    m10.CurrentWrist = new Item
                    {
                        Id = 606,
                        Name = "Iron Bracers",
                        Power = 6,
                        Type = "wrist"
                    };
                    m10.CurrentWeapon = null;
                };
                _context.Monster.Add(m10);
                _context.SaveChanges();
                Monster m11 = new Monster();
                {
                    m11.Id = 11;
                    m11.Name = "Giant Snake";
                    m11.Health = 200;
                    m11.Power = 10;
                    m11.Image = "https://i.imgur.com/eRN11KR.png";
                    m11.CurrentHelmet = null;
                    m11.CurrentChest = null;
                    m11.CurrentWrist = null;
                    m11.CurrentWeapon = null;
                };
                _context.Monster.Add(m11);
                _context.SaveChanges();
                Monster m12 = new Monster();
                {
                    m12.Id = 12;
                    m12.Name = "Lava Dragon";
                    m12.Health = 300;
                    m12.Power = 10;
                    m12.Image = "https://i.imgur.com/LROimXT.jpg";
                    m12.CurrentHelmet = null;
                    m12.CurrentChest = null;
                    m12.CurrentWrist = null;
                    m12.CurrentWeapon = new Item
                    {
                        Id = 1800,
                        Name = "Dragon Dagger",
                        Power = 50,
                        Type = "weapon",
                        Image = "https://i.imgur.com/kwPiOCK.png"
                    };
                };
                _context.Monster.Add(m12);
                _context.SaveChanges();
                Monster m13 = new Monster();
                {
                    m13.Id = 13;
                    m13.Name = "Magma Snake";
                    m13.Health = 150;
                    m13.Power = 10;
                    m13.Image = "https://i.imgur.com/vY9qsKA.png";
                    m13.CurrentHelmet = null;
                    m13.CurrentChest = null;
                    m13.CurrentWrist = null;
                    m13.CurrentWeapon = null;
                };
                _context.Monster.Add(m13);
                _context.SaveChanges();
                Monster m14 = new Monster();
                {
                    m14.Id = 14;
                    m14.Name = "Muad' Dib";
                    m14.Health = 75;
                    m14.Power = 15;
                    m14.Image = "https://i.imgur.com/XwCpGCs.png";
                    m14.CurrentHelmet = null;
                    m14.CurrentChest = new Item
                    {
                        Id = 261,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    };
                    m14.CurrentWrist = null;
                    m14.CurrentWeapon = new Item
                    {
                        Id = 172,
                        Name = "Twin Daggers",
                        Power = 25,
                        Type = "weapon",
                        Image = "https://i.imgur.com/1BCiVsW.png"
                    };
                };
                _context.Monster.Add(m14);
                _context.SaveChanges();
                Monster m15 = new Monster();
                {
                    m15.Id = 15;
                    m15.Name = "Mummy";
                    m15.Health = 200;
                    m15.Power = 5;
                    m15.Image = "https://i.imgur.com/DbxfIiD.png";
                    m15.CurrentHelmet = new Item
                    {
                        Id = 271,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                    m15.CurrentChest = new Item
                    {
                        Id = 263,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    };
                    m15.CurrentWrist = null;
                    m15.CurrentWeapon = new Item
                    {
                        Id = 274,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                };
                _context.Monster.Add(m15);
                _context.SaveChanges();
                Monster m16 = new Monster();
                {
                    m16.Id = 16;
                    m16.Name = "Old Man";
                    m16.Health = 30;
                    m16.Power = 1;
                    m16.Image = "https://i.imgur.com/Ue8lKY1.png";
                    m16.CurrentHelmet = new Item
                    {
                        Id = 274,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                    m16.CurrentChest = new Item
                    {
                        Id = 265,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    };
                    m16.CurrentWrist = null;
                    m16.CurrentWeapon = new Item
                    {
                        Id = 276,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                };
                _context.Monster.Add(m16);
                _context.SaveChanges();
                Monster m17 = new Monster();
                {
                    m17.Id = 17;
                    m17.Name = "Rock Golem";
                    m17.Health = 200;
                    m17.Power = 10;
                    m17.Image = "https://i.imgur.com/pBKoMd6.png";
                    m17.CurrentHelmet = new Item
                    {
                        Id = 278,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                    m17.CurrentChest = new Item
                    {
                        Id = 269,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    };
                    m17.CurrentWrist = null;
                    m17.CurrentWeapon = new Item
                    {
                        Id = 111,
                        Name = "War Hammer",
                        Power = 40,
                        Type = "weapon",
                        Image = "https://i.imgur.com/nNjnfMu.png"
                    };
                };
                _context.Monster.Add(m17);
                _context.SaveChanges();
                Monster m18 = new Monster();
                {
                    m18.Id = 18;
                    m18.Name = "Sand Worm";
                    m18.Health = 100;
                    m18.Power = 15;
                    m18.Image = "https://i.imgur.com/PSJ2dEv.png";
                    m18.CurrentHelmet = new Item
                    {
                        Id = 2701,
                        Name = "Large Potion",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                    m18.CurrentChest = new Item
                    {
                        Id = 2602,
                        Name = "Medium Potion",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    };
                    m18.CurrentWrist = null;
                    m18.CurrentWeapon = null;
                };
                _context.Monster.Add(m18);
                _context.SaveChanges();
                Monster m19 = new Monster();
                {
                    m19.Id = 19;
                    m19.Name = "Ice Golem";
                    m19.Health = 300;
                    m19.Power = 10;
                    m19.Image = "https://i.imgur.com/1Aj1njR.png";
                    m19.CurrentHelmet = new Item
                    {
                        Id = 312,
                        Name = "Plate Helm",
                        Power = 20,
                        Type = "helmet",
                        Image = "https://i.imgur.com/MSLjTpx.png"
                    };
                    m19.CurrentChest = new Item
                    {
                        Id = 7051,
                        Name = "Plate Armor",
                        Power = 25,
                        Type = "chest",
                        Image = "https://i.imgur.com/ilIaLPc.png"
                    };
                    m19.CurrentWrist = null;
                    m19.CurrentWeapon = new Item
                    {
                        Id = 901,
                        Name = "Maul",
                        Power = 60,
                        Type = "weapon",
                        Image = "https://i.imgur.com/hXAEbM1.png"
                    };
                };
                _context.Monster.Add(m19);
                _context.SaveChanges();
                Monster m20 = new Monster();
                {
                    m20.Id = 20;
                    m20.Name = "Noah after this Week";
                    m20.Health = 200;
                    m20.Power = 20;
                    m20.Image = "https://i.imgur.com/C7pmDXw.png";
                    m20.CurrentHelmet = new Item
                    {
                        Id = 27234,
                        Name = "Dank Meme Sauce",
                        Power = 200,
                        Type = "heal",
                        Image = "https://i.imgur.com/DdBNUSi.png"
                    };
                    m20.CurrentChest = new Item
                    {
                        Id = 26124,
                        Name = "Meme Sauce",
                        Power = 100,
                        Type = "heal",
                        Image = "https://i.imgur.com/qDkCEFe.png"
                    };
                    m20.CurrentWrist = null;
                    m20.CurrentWeapon = null;
                };
                _context.Monster.Add(m20);
                _context.SaveChanges();
                Monster m21 = new Monster();
                {
                    m21.Id = 21;
                    m21.Name = "Toxic Cloud";
                    m21.Health = 100;
                    m21.Power = 10;
                    m21.Image = "https://i.imgur.com/l0hl017.png";
                    m21.CurrentHelmet = null;
                    m21.CurrentChest = null;
                    m21.CurrentWrist = null;
                    m21.CurrentWeapon = null;
                };
                _context.Monster.Add(m21);
                _context.SaveChanges();
                Monster m22 = new Monster();
                {
                    m22.Id = 22;
                    m22.Name = "Vicious Cloud Dog";
                    m22.Health = 75;
                    m22.Power = 15;
                    m22.Image = "https://i.imgur.com/tgvAYnF.jpg";
                    m22.CurrentHelmet = null;
                    m22.CurrentChest = null;
                    m22.CurrentWrist = null;
                    m22.CurrentWeapon = null;
                };
                _context.Monster.Add(m22);
                _context.SaveChanges();
                Monster m23 = new Monster();
                {
                    m23.Id = 23;
                    m23.Name = "Imp";
                    m23.Health = 250;
                    m23.Power = 15;
                    m23.Image = "https://i.imgur.com/iCaGpRE.png";
                    m23.CurrentHelmet = null;
                    m23.CurrentChest = null;
                    m23.CurrentWrist = null;
                    m23.CurrentWeapon = new Item
                    {
                        Id = 1999,
                        Name = "Explosive Staff",
                        Power = 60,
                        Type = "weapon",
                        Image = "https://i.imgur.com/u0JVNz2.png"
                    };
                };
                _context.Monster.Add(m23);
                _context.SaveChanges();
                Monster m24 = new Monster();
                {
                    m24.Id = 24;
                    m24.Name = "Wolf";
                    m24.Health = 55;
                    m24.Power = 5;
                    m24.Image = "https://i.imgur.com/AvbsjzM.png";
                    m24.CurrentHelmet = null;
                    m24.CurrentChest = null;
                    m24.CurrentWrist = null;
                    m24.CurrentWeapon = null;
                };
                _context.Monster.Add(m24);
                _context.SaveChanges();
                Monster m25 = new Monster();
                {
                    m25.Id = 25;
                    m25.Name = "King of Redwood";
                    m25.Health = 400;
                    m25.Power = 30;
                    m25.Image = "https://i.imgur.com/QeYrLVx.png";
                    m25.CurrentHelmet = new Item
                    {
                        Id = 3987,
                        Name = "Plate Helm",
                        Power = 20,
                        Type = "helmet",
                        Image = "https://i.imgur.com/MSLjTpx.png"
                    };
                    m25.CurrentChest = new Item
                    {
                        Id = 7876,
                        Name = "Plate Armor",
                        Power = 25,
                        Type = "Chest",
                        Image = "https://i.imgur.com/ilIaLPc.png"
                    };
                    m25.CurrentWrist = null;
                    m25.CurrentWeapon = new Item
                    {
                        Id = 15284,
                        Name = "EPIC Sword",
                        Power = 70,
                        Type = "weapon",
                        Image = "https://i.imgur.com/poj0jfC.png"
                    };

                    Monster m26 = new Monster();
                    {
                        m26.Id = 26;
                        m26.Name = "Hooded Figure";
                        m26.Health = 500;
                        m26.Power = 50;
                        m26.Image = "https://i.imgur.com/QeYrLVx.png";
                        m26.CurrentHelmet = null;
                        m26.CurrentChest = null;
                        m26.CurrentWrist = null;
                        m26.CurrentWeapon = null;
                    };
                }
                _context.Monster.Add(m25);
                _context.SaveChanges();
            }
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
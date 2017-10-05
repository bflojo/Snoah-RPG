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
    [Route("api/Locations")]
    public class LocationsController : Controller
    {
        private readonly SnoahRpgContext _context;

        public LocationsController(SnoahRpgContext context)
        {
            _context = context;


            if (_context.Location.Count() == 0)
            {
                
                Location l1 = new Location();
                {
                    l1.Id = 1;
                    l1.Name = "Forest 1";
                    l1.Image = "https://i.imgur.com/1LEQutv.jpg";
                };
                _context.Location.Add(l1);
                _context.SaveChanges();
                Location l2 = new Location();
                {
                    l2.Id = 2;
                    l2.Name = "Forest 2";
                    l2.Image = "https://i.imgur.com/1JZezCN.jpg";
                };
                _context.Location.Add(l2);
                _context.SaveChanges();
                Location l3 = new Location();
                {
                    l3.Id = 3;
                    l3.Name = "Forest 3";
                    l3.Image = "https://i.imgur.com/oz9if8c.jpg";
                };
                _context.Location.Add(l3);
                _context.SaveChanges();
                Location l4 = new Location();
                {
                    l4.Id = 4;
                    l4.Name = "Forest 4";
                    l4.Image = "https://i.imgur.com/VXfa18m.jpg";
                };
                _context.Location.Add(l4);
                _context.SaveChanges();
                Location l5 = new Location();
                {
                    l5.Id = 5;
                    l5.Name = "Forest 4 To Mountain";
                    l5.Image = "https://i.imgur.com/ltJBFcR.jpg";
                };
                _context.Location.Add(l5);
                _context.SaveChanges();
                Location l6 = new Location();
                {
                    l6.Id = 6;
                    l6.Name = "Mountain 1";
                    l6.Image = "https://i.imgur.com/FOuIIrh.jpg";
                };
                _context.Location.Add(l6);
                _context.SaveChanges();
                Location l7 = new Location();
                {
                    l7.Id = 7;
                    l7.Name = "Mountain 2";
                    l7.Image = "https://i.imgur.com/sTVbIic.jpg";
                };
                _context.Location.Add(l7);
                _context.SaveChanges();
                Location l8 = new Location();
                {
                    l8.Id = 8;
                    l8.Name = "Mountain 3";
                    l8.Image = "https://i.imgur.com/lvASEcX.jpg";
                };
                _context.Location.Add(l8);
                _context.SaveChanges();
                Location l9 = new Location();
                {
                    l9.Id = 9;
                    l9.Name = "Mountain 3 Snow Mountain";
                    l9.Image = "https://i.imgur.com/DQSZAXn.jpg";
                };
                _context.Location.Add(l9);
                _context.SaveChanges();
                Location l10 = new Location();
                {
                    l10.Id = 10;
                    l10.Name = "Snow 1";
                    l10.Image = "https://i.imgur.com/FgVVgpR.jpg";
                };
                _context.Location.Add(l10);
                _context.SaveChanges();
                Location l11 = new Location();
                {
                    l11.Id = 11;
                    l11.Name = "Snow 2";
                    l11.Image = "https://i.imgur.com/YcptPDb.jpg";
                };
                _context.Location.Add(l11);
                _context.SaveChanges();
                Location l12 = new Location();
                {
                    l12.Id = 12;
                    l12.Name = "Snow 3";
                    l12.Image = "https://i.imgur.com/FgVVgpR.jpg";
                };
                _context.Location.Add(l12);
                _context.SaveChanges();
                Location l13 = new Location();
                {
                    l13.Id = 13;
                    l13.Name = "Snow 4";
                    l13.Image = "https://i.imgur.com/wwFEqED.jpg";
                };
                _context.Location.Add(l13);
                _context.SaveChanges();
                Location l14 = new Location();
                {
                    l14.Id = 14;
                    l14.Name = "Snow 5";
                    l14.Image = "https://i.imgur.com/gXhpBPQ.jpg";
                };
                _context.Location.Add(l14);
                _context.SaveChanges();
                Location l15 = new Location();
                {
                    l15.Id = 15;
                    l15.Name = "Rocky Path 1";
                    l15.Image = "https://i.imgur.com/Iv6psXn.jpg";
                };
                _context.Location.Add(l15);
                _context.SaveChanges();
                Location l16 = new Location();
                {
                    l16.Id = 16;
                    l16.Name = "Rocky Path 2";
                    l16.Image = "https://i.imgur.com/dtY1r3N.jpg";
                };
                _context.Location.Add(l16);
                _context.SaveChanges();
                Location l17 = new Location();
                {
                    l17.Id = 17;
                    l17.Name = "Volcano 1";
                    l17.Image = "https://i.imgur.com/vvcBzQ4.jpg";
                };
                _context.Location.Add(l17);
                _context.SaveChanges();
                Location l18 = new Location();
                {
                    l18.Id = 18;
                    l18.Name = "Volcano 2";
                    l18.Image = "https://i.imgur.com/LCEnJkp.jpg";
                };
                _context.Location.Add(l18);
                _context.SaveChanges();
                Location l19 = new Location();
                {
                    l19.Id = 19;
                    l19.Name = "Volcano 3";
                    l19.Image = "https://i.imgur.com/bUrg6dV.jpg";
                };
                _context.Location.Add(l19);
                _context.SaveChanges();
                Location l20 = new Location();
                {
                    l20.Id = 20;
                    l20.Name = "Volcano 4";
                    l20.Image = "https://i.imgur.com/fxI262Dg.jpg";
                };
                _context.Location.Add(l20);
                _context.SaveChanges();
                Location l21 = new Location();
                {
                    l21.Id = 21;
                    l21.Name = "Volcano 5";
                    l21.Image = "https://i.imgur.com/E5htIss.jpg";
                };
                _context.Location.Add(l21);
                _context.SaveChanges();
                Location l22 = new Location();
                {
                    l22.Id = 22;
                    l22.Name = "Castle 1";
                    l22.Image = "https://i.imgur.com/DxHULEV.jpg";
                };
                _context.Location.Add(l22);
                _context.SaveChanges();
                Location l23 = new Location();
                {
                    l23.Id = 23;
                    l23.Name = "Castle 2";
                    l23.Image = "https://i.imgur.com/Eea85aq.jpg";
                };
                _context.Location.Add(l23);
                _context.SaveChanges();
                Location l24 = new Location();
                {
                    l24.Id = 24;
                    l24.Name = "Castle 3";
                    l24.Image = "https://i.imgur.com/VETxcXf.jpg";
                };
                _context.Location.Add(l24);
                _context.SaveChanges();
                Location l25 = new Location();
                {
                    l25.Id = 25;
                    l25.Name = "Castle 4";
                    l25.Image = "https://i.imgur.com/UNgvAor.jpg";
                };
                _context.Location.Add(l25);
                _context.SaveChanges();
                Location l26 = new Location();
                {
                    l26.Id = 26;
                    l26.Name = "Castle Hidden Room 1";
                    l26.Image = "https://i.imgur.com/M1NEFEq.jpg";
                };
                _context.Location.Add(l26);
                _context.SaveChanges();
                Location l27 = new Location();
                {
                    l27.Id = 27;
                    l27.Name = "Castle Hidden Room 2";
                    l27.Image = "https://i.imgur.com/s6zpFNL.jpg";
                };
                _context.Location.Add(l27);
                _context.SaveChanges();
                Location l28 = new Location();
                {
                    l28.Id = 28;
                    l28.Name = "Desert 1";
                    l28.Image = "https://i.imgur.com/ivnnPAu.jpg";
                };
                _context.Location.Add(l28);
                _context.SaveChanges();
                Location l29 = new Location();
                {
                    l29.Id = 29;
                    l29.Name = "Desert 2";
                    l29.Image = "https://i.imgur.com/rnkx7BN.jpg";
                };
                _context.Location.Add(l29);
                _context.SaveChanges();
                Location l30 = new Location();
                {
                    l30.Id = 30;
                    l30.Name = "Desert 3";
                    l30.Image = "https://i.imgur.com/op6K9AR.jpg";
                };
                _context.Location.Add(l30);
                _context.SaveChanges();
                Location l31 = new Location();
                {
                    l31.Id = 31;
                    l31.Name = "Desert 3 Cave 1";
                    l31.Image = "https://i.imgur.com/PEGIMJ9.jpg";
                };
                _context.Location.Add(l31);
                _context.SaveChanges();
                Location l32 = new Location();
                {
                    l32.Id = 32;
                    l32.Name = "Desert 3 Cave 2";
                    l32.Image = "https://i.imgur.com/9HVBQJM.jpg";
                };
                _context.Location.Add(l32);
                _context.SaveChanges();
                Location l33 = new Location();
                {
                    l33.Id = 33;
                    l33.Name = "Desert 4";
                    l33.Image = "https://i.imgur.com/43sMyuW.jpg";
                };
                _context.Location.Add(l33);
                _context.SaveChanges();
                Location l34 = new Location();
                {
                    l34.Id = 34;
                    l34.Name = "Desert 5 (Oasis 1)";
                    l34.Image = "https://i.imgur.com/ttAZqXU.jpg";
                };
                _context.Location.Add(l34);
                _context.SaveChanges();
                Location l35 = new Location();
                {
                    l35.Id = 35;
                    l35.Name = "Oasis 2";
                    l35.Image = "https://i.imgur.com/7PNVIzU.jpg";
                };
                _context.Location.Add(l35);
                _context.SaveChanges();
                Location l36 = new Location();
                {
                    l36.Id = 36;
                    l36.Name = "Oasis 3";
                    l36.Image = "https://i.imgur.com/5b3bvbT.jpg";
                };
                _context.Location.Add(l36);
                _context.SaveChanges();
                Location l37 = new Location();
                {
                    l37.Id = 37;
                    l37.Name = "Oasis 4";
                    l37.Image = "https://i.imgur.com/Pr3fzzh.jpg";
                };
                _context.Location.Add(l37);
                _context.SaveChanges();
                Location l38 = new Location();
                {
                    l38.Id = 38;
                    l38.Name = "Ruins 1";
                    l38.Image = "https://i.imgur.com/ySWJX0x.jpg";
                };
                _context.Location.Add(l38);
                _context.SaveChanges();
                Location l39 = new Location();
                {
                    l39.Id = 39;
                    l39.Name = "Ruins 2";
                    l39.Image = "https://i.imgur.com/h4Kij1b.jpg";
                };
                _context.Location.Add(l39);
                _context.SaveChanges();
                Location l40 = new Location();
                {
                    l40.Id = 40;
                    l40.Name = "Ruins 2 (Right)";
                    l40.Image = "https://i.imgur.com/E1sEBPj.jpg";
                };
                _context.Location.Add(l40);
                _context.SaveChanges();
                Location l41 = new Location();
                {
                    l41.Id = 41;
                    l41.Name = "Ruins 2 (Left)";
                    l41.Image = "https://i.imgur.com/yVHOvzpg.jpg";
                };
                _context.Location.Add(l41);
                _context.SaveChanges();
                Location l42 = new Location();
                {
                    l42.Id = 42;
                    l42.Name = "Ruins 3 (Left)";
                    l42.Image = "https://i.imgur.com/m00FbKj.jpg";
                };
                _context.Location.Add(l42);
                _context.SaveChanges();
                Location l43 = new Location();
                {
                    l43.Id = 43;
                    l43.Name = "Cave 1";
                    l43.Image = "https://i.imgur.com/cUfMnf8.jpg";
                };
                _context.Location.Add(l43);
                _context.SaveChanges();
                Location l44 = new Location();
                {
                    l44.Id = 44;
                    l44.Name = "Cave 2";
                    l44.Image = "https://i.imgur.com/QUNi8wN.jpg";
                };
                _context.Location.Add(l44);
                _context.SaveChanges();
                Location l45 = new Location();
                {
                    l45.Id = 45;
                    l45.Name = "Cloud City 1";
                    l45.Image = "https://i.imgur.com/sKG8TGz.jpg";
                };
                _context.Location.Add(l45);
                _context.SaveChanges();
                Location l46 = new Location();
                {
                    l46.Id = 46;
                    l46.Name = "Cloud City 2";
                    l46.Image = "https://i.imgur.com/awh2Lzd.jpg";
                };
                _context.Location.Add(l46);
                _context.SaveChanges();
            }
        }

        // GET: api/Locations
        [HttpGet]
        public IEnumerable<Location> GetLocation()
        {
            return _context.Location;
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var location = await _context.Location.SingleOrDefaultAsync(m => m.Id == id);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        // PUT: api/Locations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation([FromRoute] int id, [FromBody] Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != location.Id)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/Locations
        [HttpPost]
        public async Task<IActionResult> PostLocation([FromBody] Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Location.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var location = await _context.Location.SingleOrDefaultAsync(m => m.Id == id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Location.Remove(location);
            await _context.SaveChangesAsync();

            return Ok(location);
        }

        private bool LocationExists(int id)
        {
            return _context.Location.Any(e => e.Id == id);
        }
    }
}
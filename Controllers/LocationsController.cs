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
          Location l1 = new Location
                {
                Id = 1,
                Name = "Forest 1",
                Image = "https://imgur.com/wNlzzIO",
                Type = "Forest",
                Item = null,
                };

          Location l2 = new Location
                {
                Id = 2,
                Name = "Forest 2",
                Image = "https://imgur.com/ZNegY10",
                Type = "Forest",
                Item = null,
                };


          Location l3 = new Location
                {
                Id = 3,
                Name = "Forest 3",
                Image = "https://imgur.com/ubepNXt",
                Type = "Forest",
                Item = null,
                };

          Location l4 = new Location
                {
                Id = 4,
                Name = "Forest 4",
                Image = "https://imgur.com/Agd6SiO",
                Type = "Forest",
                Item = null,
                };

          Location l5 = new Location
                {
                Id = 5,
                Name = "Forest 5",
                Image = "https://imgur.com/yzDIooF",
                Type = "Forest",
                Item = null,
                };



          Location l6 = new Location
                {
                Id = 6,
                Name = "Cave 1",
                Image = "https://imgur.com/hETU43V",
                Type = "Cave",
                Item = null,
                };

          Location l7 = new Location
                {
                Id = 7,
                Name = "Cave 2",
                Image = "https://imgur.com/qS77DUe",
                Type = "Cave",
                Item = null,
                };


          Location l8 = new Location
                {
                Id = 8,
                Name = "Desert 1",
                Image = "https://imgur.com/0kd7KKf",
                Type = "Desert",
                Item = null,
                };

          Location l9 = new Location
                {
                Id = 9,
                Name = "Desert 2",
                Image = "https://imgur.com/1CA5n7s",
                Type = "Desert",
                Item = null,
                };

          Location l10 = new Location
                {
                Id = 10,
                Name = "Desert 3",
                Image = "https://imgur.com/EZWaeOV",
                Type = "Desert",
                Item = null,
                };

          Location l11 = new Location
                {
                Id = 11,
                Name = "Desert 3 Cave 1",
                Image = "https://imgur.com/v3O5d6n",
                Type = "Desert",
                Item = null,
                };

          Location l12 = new Location
                {
                Id = 12,
                Name = "Desert 3 Cave 2",
                Image = "https://imgur.com/UFJSAlc",
                Type = "Desert",
                Item = null,
                };


          Location l13 = new Location
                {
                Id = 13,
                Name = "Desert 4",
                Image = "https://imgur.com/wMjyRcZ",
                Type = "Desert",
                Item = null,
                };


          Location l14 = new Location
                {
                Id = 14,
                Name = "Desert 5/Oasis 1",
                Image = "https://imgur.com/Yar4NUJ",
                Type = "Desert",
                Item = null,
                };

          Location l15 = new Location
                {
                Id = 15,
                Name = "Oasis 2",
                Image = "https://imgur.com/k3W4I9M",
                Type = "Oasis",
                Item = null,
                };

          Location l16 = new Location
                {
                Id = 16,
                Name = "Oasis 3",
                Image = "https://imgur.com/PW7xFXa",
                Type = "Oasis",
                Item = null,
                };

          Location l17 = new Location
                {
                Id = 17,
                Name = "Oasis 4",
                Image = "https://imgur.com/L6NI9J4",
                Type = "Oasis",
                Item = null,
                };


          Location l18 = new Location
                {
                Id = 18,
                Name = "Ruins 1",
                Image = "https://imgur.com/Uz61I4Q",
                Type = "Ruins",
                Item = null,
                };

          Location l19 = new Location
                {
                Id = 19,
                Name = "Ruins 2 (left)",
                Image = "https://imgur.com/AsknfaL",
                Type = "Ruins",
                Item = null,
                };

          Location l20 = new Location
                {
                Id = 20,
                Name = "Ruins 2 (right)",
                Image = "https://imgur.com/08Fg33p",
                Type = "Ruins",
                Item = null,
                };

          Location l21 = new Location
                {
                Id = 21,
                Name = "Ruins 2",
                Image = "https://imgur.com/pirkNpm",
                Type = "Ruins",
                Item = null,
                };

          Location l22 = new Location
                {
                Id = 22,
                Name = "Ruins 3 left",
                Image = "https://imgur.com/PoMwPJb",
                Type = "Ruins",
                Item = null,
                };


          Location l23 = new Location
                {
                Id = 23,
                Name = "Mountain 1",
                Image = "https://imgur.com/ZExQ9p0",
                Type = "Mountain",
                Item = null,
                };

         Location l24 = new Location
                {
                Id = 24,
                Name = "Mountain 2",
                Image = "https://imgur.com/3BiF7jI",
                Type = "Mountain",
                Item = null,
                };

         Location l25 = new Location
                {
                Id = 25,
                Name = "Mountain 3",
                Image = "https://imgur.com/wa794wj",
                Type = "Mountain",
                Item = null,
                };

         Location l26 = new Location
                {
                Id = 26,
                Name = "Mountain 3 snow path",
                Image = "https://imgur.com/JtlY5Fz",
                Type = "Mountain",
                Item = null,
                };


         Location l27 = new Location
                {
                Id = 27,
                Name = "Snow 1",
                Image = "https://imgur.com/xhGXSe9",
                Type = "Snow",
                Item = null,
                };




        Location l28 = new Location
                {
                Id = 28,
                Name = "Snow 2",
                Image = "",
                Type = "Snow",
                Item = null,
                };

        Location l29 = new Location
                {
                Id = 29,
                Name = "Snow 3",
                Image = "https://imgur.com/25b5W36",
                Type = "Snow",
                Item = null,
                };

        Location l30 = new Location
                {
                Id = 30,
                Name = "Snow 4",
                Image = "",
                Type = "Snow",
                Item = null,
                };


        Location l31 = new Location
                {
                Id = 31,
                Name = "Snow 5",
                Image = "https://imgur.com/kZaWytF",
                Type = "Snow",
                Item = null,
                };

        Location l32 = new Location
                {
                Id = 32,
                Name = "Rocky Path 1",
                Image = "https://imgur.com/otInO3Q",
                Type = "Rocky Path",
                Item = null,
                };

        Location l33 = new Location
                {
                Id = 33,
                Name = "Rocky Path 2",
                Image = "https://imgur.com/bSrRYHU",
                Type = "Rocky Path",
                Item = null,
                };

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
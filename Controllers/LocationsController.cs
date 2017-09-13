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
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> 151848cf6b74594dce7b8ba219270174e8fabd71
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
        Location castleTown1 = new Location();
        castleTown1.Id = 1;
        castleTown1.Name = "CastleTown1";
        // castleTown1.Image = ;

        castleTown1.Type = "CastleTown";

<<<<<<< HEAD
        //castleTown1.Item = ;
=======
        castleTown1.Item = ;
>>>>>>> 151848cf6b74594dce7b8ba219270174e8fabd71

      }
    }
    // Add items to list here




    //         }


    //             {

    //                 Location forest1 = new Location();
    //                 forest1.Id = 1;
    //                 forest1.Name = "Forest1";
    //                 forest1.Image = "Forest1.jpg"

    //                 forest1.Type = "Forest";

    //                 forest1.Item = h1;

    //             }
    // // Add items to list here




    //         }



    //              {

    //                 Location forest2 = new Location();
    //                 forest2.Id = 2;
    //                 forest2.Name = "Forest2";
    //                 forest2.Image = ;

    //                 forest2.Type = "Forest";

    //                 forest2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location forest3 = new Location();
    //                 forest3.Id = 3;
    //                 forest3.Name = "Forest";
    //                 forest3.Image = ;

    //                 forest3.Type = "Forest";

    //                 forest3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }








    //      {

    //                 Location forest4 = new Location();
    //                 forest4.Id = 4;
    //                 forest4.Name = "Forest4";
    //                 forest4.Image = ;

    //                 forest4.Type = "Forest";

    //                 forest4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }











    //      {

    //                 Location forest5 = new Location();
    //                 forest5.Id = 5;
    //                 forest5.Name = "Forest5";
    //                 forest5.Image = ;

    //                 forest5.Type = "Forest";

    //                 forest5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location desert1 = new Location();
    //                 desert1.Id = 1;
    //                 desert1.Name = "Desert1";
    //                 desert1.Image = ;

    //                 desert1.Type = "Desert";

    //                 desert1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }


    //      {

    //                 Location desert2 = new Location();
    //                 desert2.Id = 2;
    //                 desert2.Name = "Desert2";
    //                 desert2.Image = ;

    //                 desert2.Type = "Desert";

    //                 desert2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }

    //      {

    //                 Location desert3 = new Location();
    //                 desert3.Id = 3;
    //                 desert3.Name = "Desert3";
    //                 desert3.Image = ;

    //                 desert3.Type = "Desert";

    //                 desert3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }


    //      {

    //                 Location desert4 = new Location();
    //                 desert4.Id = 4;
    //                 desert4.Name = "Desert4";
    //                 desert4.Image = ;

    //                 desert4.Type = "Desert";

    //                 desert4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }


    //      {

    //                 Location desert5 = new Location();
    //                 desert5.Id = 5;
    //                 desert5.Name = "Desert5";
    //                 desert5.Image = ;

    //                 desert5.Type = "Desert";

    //                 desert5.Items = new List<Item>();

    //             }
    // // Add items to list here

    //         }


    //      {

    //                 Location oasis1 = new Location();
    //                 oasis1.Id = 1;
    //                 oasis1.Name = "Oasis1";
    //                 oasis1.Image = ;

    //                 oasis1.Type = "Oasis";

    //                 oasis1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }






    //      {

    //                 Location oasis2 = new Location();
    //                 oasis2.Id = 2;
    //                 oasis2.Name = "Oasis2";
    //                 oasis2.Image = ;

    //                 oasis2.Type = "Oasis";

    //                 oasis2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location oasis3 = new Location();
    //                 oasis3.Id = 3;
    //                 oasis3.Name = "Oasis3";
    //                 oasis3.Image = ;

    //                 oasis3.Type = "Oasis";

    //                 oasis3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }

    //              {

    //                 Location oasis4 = new Location();
    //                 oasis4.Id = 4;
    //                 oasis4.Name = "Oasis4";
    //                 oasis4.Image = ;

    //                 oasis4.Type = "Oasis";

    //                 oasis4.Items = new List<Item>();

    //             }
    // // Add items to list here

    //         }




    //      {

    //                 Location oasis5 = new Location();
    //                 oasis5.Id = 5;
    //                 oasis5.Name = "Oasis5";
    //                 oasis5.Image = ;

    //                 oasis5.Type = "Oasis";

    //                 oasis5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location ruins1 = new Location();
    //                 ruins1.Id = 1;
    //                 ruins1.Name = "Ruins1";
    //                 ruins1.Image = ;

    //                 ruins1.Type = "Ruins";

    //                 ruins1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }






    //      {

    //                 Location ruins2 = new Location();
    //                 ruins2.Id = 2;
    //                 ruins2.Name = "Ruins2";
    //                 ruins2.Image = ;

    //                 ruins2.Type = "Ruins";

    //                 ruins2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location ruins3 = new Location();
    //                 ruins3.Id = 3;
    //                 ruins3.Name = "Ruins3";
    //                 ruins3.Image = ;

    //                 ruins3.Type = "Ruins";

    //                 ruins3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location ruins4 = new Location();
    //                 ruins4.Id = 4;
    //                 ruins4.Name = "Ruins4";
    //                 ruins4.Image = ;

    //                 ruins4.Type = "Ruins";

    //                 ruins4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location ruins5 = new Location();
    //                 ruins5.Id = 5;
    //                 ruins5.Name = "Ruins5";
    //                 ruins5.Image = ;

    //                 ruins5.Type = "Ruins";

    //                 ruins5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }









    //      {

    //                 Location portal = new Location();
    //                 portal.Id = 1;
    //                 portal.Name = "Portal";
    //                 portal.Image = ;

    //                 portal.Type = "Portal";

    //                 portal.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location mountain1 = new Location();
    //                 mountain1.Id = 1;
    //                 mountain1.Name = "Mountain1";
    //                 mountain1.Image = ;

    //                 mountain1.Type = "Mountain";

    //                 mountain1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location mountain2 = new Location();
    //                 mountain2.Id = 2;
    //                 mountain2.Name = "Mountain2";
    //                 mountain2.Image = ;

    //                 mountain2.Type = "Mountain";

    //                 mountain2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location mountain3 = new Location();
    //                 mountain3.Id = 3;
    //                 mountain3.Name = "Mountain3";
    //                 mountain3.Image = ;

    //                 mountain3.Type = "Mountain";

    //                 mountain3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }








    //      {

    //                 Location mountain4 = new Location();
    //                 mountain4.Id = 4;
    //                 mountain4.Name = "Mountain4";
    //                 mountain4.Image = ;

    //                 mountain4.Type = "Mountain";

    //                 mountain4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location mountain5 = new Location();
    //                 mountain5.Id = 5;
    //                 mountain5.Name = "Mountain5";
    //                 mountain5.Image = ;

    //                 mountain5.Type = "Mountain";

    //                 mountain5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //              {

    //                 Location cave1 = new Location();
    //                 cave1.Id = 1;
    //                 cave1.Name = "Cave1";
    //                 cave1.Image = ;

    //                 cave1.Type = "Cave";

    //                 cave1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location cave2 = new Location();
    //                 cave2.Id = 2;
    //                 cave2.Name = "Cave2";
    //                 cave2.Image = ;

    //                 cave2.Type = "Cave";

    //                 cave2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }


    //              {

    //                 Location cave3 = new Location();
    //                 cave3.Id = 3;
    //                 cave3.Name = "Cave3";
    //                 cave3.Image = ;

    //                 cave3.Type = "Cave";

    //                 cave3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location cave4 = new Location();
    //                 cave4.Id = 4;
    //                 cave4.Name = "Cave4";
    //                 cave4.Image = ;

    //                 cave4.Type = "Cave";

    //                 cave4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location cave5 = new Location();
    //                 cave5.Id = 5;
    //                 cave5.Name = "Cave5";
    //                 cave5.Image = ;

    //                 cave5.Type = "Cave";

    //                 cave5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location snow1 = new Location();
    //                 snow1.Id = 1;
    //                 snow1.Name = "Snow1";
    //                 snow1.Image = ;

    //                 snow1.Type = "Snow";

    //                 snow1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location snow2 = new Location();
    //                 snow2.Id = 2;
    //                 snow2.Name = "Snow2";
    //                 snow2.Image = ;

    //                 snow2.Type = "Snow";

    //                 snow2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location snow3 = new Location();
    //                 snow3.Id = 3;
    //                 snow3.Name = "snow3";
    //                 snow3.Image = ;

    //                 snow3.Type = "snow";

    //                 snow3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }


    //      {

    //                 Location snow4 = new Location();
    //                 snow4.Id = 4;
    //                 snow4.Name = "snow4";
    //                 snow4.Image = ;

    //                 snow4.Type = "Snow";

    //                 snow4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location snow5 = new Location();
    //                 snow5.Id = 5;
    //                 snow5.Name = "Snow5";
    //                 snow5.Image = ;

    //                 snow5.Type = "Snow";

    //                 snow5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //              {

    //                 Location forest1 = new Location();
    //                 forest1.Id = 1;
    //                 forest1.Name = "Forest1";
    //                 forest1.Image = ;

    //                 forest1.Type = "Forest";

    //                 forest1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }

    //      {

    //                 Location rockyPath = new Location();
    //                 rockyPath.Id = 1;
    //                 rockyPath.Name = "RockyPath";
    //                 rockyPath.Image = ;

    //                 rockyPath.Type = "RockPath";

    //                 rockyPath.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location beacon = new Location();
    //                 beacon.Id = 1;
    //                 beacon.Name = "Beacon";
    //                 beacon.Image = ;

    //                 beacon.Type = "Beacon";

    //                 beacon.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }







    //              {

    //                 Location cloudcity = new Location();
    //                 cloudcity.Id = 1;
    //                 cloudcity.Name = "Cloudcity";
    //                 cloudcity.Image = ;

    //                 cloudcity.Type = "CloudCity";

    //                 cloudcity.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location cloudcity2 = new Location();
    //                 cloudcity2.Id = 2;
    //                 cloudcity2.Name = "Cloudcity2";
    //                 cloudcity2.Image = ;

    //                 cloudcity2.Type = "Cloudcity";

    //                 cloudcity2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location cloudcity3 = new Location();
    //                 cloudcity.Id = 3;
    //                 cloudcity.Name = "CloudCity3";
    //                 cloudcity.Image = ;

    //                 cloudcity.Type = "CloudCity";

    //                 cloudcity.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location cloudcity4 = new Location();
    //                 cloudcity4.Id = 4;
    //                 cloudcity4.Name = "CloudCity4";
    //                 cloudcity4.Image = ;

    //                 cloudcity4.Type = "CloudCity";

    //                 cloudcity4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }








    //      {

    //                 Location cloudcity5 = new Location();
    //                 cloudcity5.Id = 5;
    //                 cloudcity5.Name = "CloudCity5";
    //                 cloudcity5.Image = ;

    //                 cloudcity5.Type = "CloudCity";

    //                 cloudcity5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location volcano1 = new Location();
    //                 volcano1.Id = 1;
    //                 volcano1.Name = "Volcano1";
    //                 volcano1.Image = ;

    //                 volcano1.Type = "Volcano";

    //                 volcano1.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }






    //      {

    //                 Location volcano2 = new Location();
    //                 volcano2.Id = 2;
    //                 volcano2.Name = "Volcano2";
    //                 volcano2.Image = ;

    //                 volcano2.Type = "Volcano";

    //                 volcano2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }





    //      {

    //                 Location volcano3 = new Location();
    //                 volcano3.Id = 3;
    //                 volcano3.Name = "Volcano3";
    //                 volcano3.Image = ;

    //                 volcano3.Type = "Volcano";

    //                 volcano3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location volcano4 = new Location();
    //                 volcano4.Id = 4;
    //                 volcano4.Name = "volcano4";
    //                 volcano4.Image = ;

    //                 volcano4.Type = "Volcano";

    //                 volcano4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //      {

    //                 Location volcano5 = new Location();
    //                 volcano5.Id = 5;
    //                 volcano5.Name = "Volcano5";
    //                 volcano5.Image = ;

    //                 volcano5.Type = "Volcano";

    //                 volcano5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location castleRedwood = new Location();
    //                 castleRedwood.Id = 1;
    //                 castleRedwood.Name = "CastleRedwood";
    //                 castleRedwood.Image = ;

    //                 castleRedwood.Type = "CastleRedwood";

    //                 castleRedwood.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //              {

    //                 Location castleRedwood2 = new Location();
    //                 castleRedwood2.Id = 2;
    //                 castleRedwood2.Name = "CastleRedwood2";
    //                 castleRedwood2.Image = ;

    //                 castleRedwood2.Type = "CastleRedwood";

    //                 castleRedwood2.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //              {

    //                 Location castleRedwood3 = new Location();
    //                 castleRedwood3.Id = 3;
    //                 castleRedwood3.Name = "CastleRedwood3";
    //                 castleRedwood3.Image = ;

    //                 castleRedwood3.Type = "CastleRedwood";

    //                 castleRedwood3.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }




    //      {

    //                 Location castleRedwood4 = new Location();
    //                 castleRedwood4.Id = 4;
    //                 castleRedwood4.Name = "CastleRedwood4";
    //                 castleRedwood4.Image = ;

    //                 castleRedwood4.Type = "CastleRedwood";

    //                 castleRedwood4.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }

    //      {

    //                 Location castleRedwood5 = new Location();
    //                 castleRedwood5.Id = 1;
    //                 castleRedwood5.Name = "CastleRedwood5";
    //                 castleRedwood5.Image = ;

    //                 castleRedwood5.Type = "CastleRedwood";

    //                 castleRedwood5.Items = new List<Item>();

    //             }
    // // Add items to list here




    //         }



    //         public int Id { get; set; }
    //         public string Name { get; set; }
    //         public string Image { get; set; }
    //         public string Type { get; set; }
    //         public List<Item> Items { get; set; }


    //                 Store s = new Store();
    //                 s.Id = 1;
    //                 s.Name = "Spinner Depot";
    //                 s.SpinnerModels = new List<SpinnerModel>();

    //                 s.SpinnerModels.Add(new SpinnerModel
    //                 {



























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
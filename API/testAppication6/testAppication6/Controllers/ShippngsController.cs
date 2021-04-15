using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testAppication6.Models;

namespace testAppication6.Controllers
{
//API controller for shipping table

    [Route("api/[controller]")]
    [ApiController]
    public class ShippngsController : ControllerBase
    {
<<<<<<< Updated upstream
        private readonly TestDB1Context testDBobj;
        private readonly AccountsController accountsController;
        private readonly TestDB1Context testDB1Context;
        public ShippngsController(TestDB1Context context)
        {
            testDBobj = context;
=======
        private readonly TestDB1Context dbObj;
      
        public ShippngsController(TestDB1Context context)
        {
            dbObj = context;
>>>>>>> Stashed changes
        }

        // GET: api/Shippngs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shippng>>> GetShippngs()
        {
<<<<<<< Updated upstream
            return await testDBobj.Shippngs.ToListAsync();
=======
            return await dbObj.Shippngs.ToListAsync();
>>>>>>> Stashed changes
        }

        // GET: api/Shippngs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Shippng>> GetShippng(int id)
        {
<<<<<<< Updated upstream
            var shippng = await testDBobj.Shippngs.FindAsync(id);
=======
            var shippng = await dbObj.Shippngs.FindAsync(id);
>>>>>>> Stashed changes

            if (shippng == null)
            {
                return NotFound();
            }

            return shippng;
        }

        // POST: api/Shippngs
         [HttpPost]
        public async Task<ActionResult<Shippng>> PostShippng(Shippng shippng)
        {
<<<<<<< Updated upstream
            AccountsController accres = new AccountsController(testDB1Context);
            shippng.AccId = accres.getAccountResponseID();

            testDBobj.Shippngs.Add(shippng);
            try
            {
                await testDBobj.SaveChangesAsync();
=======
            AccountsController accres = new AccountsController(dbObj);
            shippng.AccId = accres.getAccountResponseID();

            dbObj.Shippngs.Add(shippng);
            try
            {
                await dbObj.SaveChangesAsync();
>>>>>>> Stashed changes
            }
            catch (DbUpdateException)
            {
                if (ShippngExists(shippng.ShipId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShippng", new { id = shippng.ShipId }, shippng);
        }

        private bool ShippngExists(int id)               //Getting forien key
        {
<<<<<<< Updated upstream
            return testDBobj.Shippngs.Any(e => e.ShipId == id);
=======
            return dbObj.Shippngs.Any(e => e.ShipId == id);
>>>>>>> Stashed changes
        }
    }
}

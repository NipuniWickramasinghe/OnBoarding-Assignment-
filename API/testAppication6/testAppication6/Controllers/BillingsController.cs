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
//Billing table controler

    [Route("api/[controller]")]
    [ApiController]
    public class BillingsController : ControllerBase
    {
<<<<<<< Updated upstream
        private readonly TestDB1Context testDBobj;
        private readonly AccountsController accountsController;
        private readonly TestDB1Context testDB1Context;

        public BillingsController(TestDB1Context context)
        {
            testDBobj = context;
=======
        private readonly TestDB1Context dbObj;

        public BillingsController(TestDB1Context context)
        {
            dbObj = context;
>>>>>>> Stashed changes
        }

        // GET: api/Billings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Billing>>> GetBillings()
        {
<<<<<<< Updated upstream
            return await testDBobj.Billings.ToListAsync();
=======
            return await dbObj.Billings.ToListAsync();
>>>>>>> Stashed changes
        }

        // GET: api/Billings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Billing>> GetBilling(int id)
        {
<<<<<<< Updated upstream
            var billing = await testDBobj.Billings.FindAsync(id);
=======
            var billing = await dbObj.Billings.FindAsync(id);
>>>>>>> Stashed changes

            if (billing == null)
            {
                return NotFound();
            }

            return billing;
        }

        // POST: api/Billings
        [HttpPost]
        public async Task<ActionResult<Billing>> PostBilling(Billing billing)
        {
<<<<<<< Updated upstream
            AccountsController accres = new AccountsController(testDB1Context);
            billing.AccId = accres.getAccountResponseID();
            testDBobj.Billings.Add(billing);
            try
            {
                await testDBobj.SaveChangesAsync();
=======
            AccountsController accres = new AccountsController(dbObj);
            billing.AccId = accres.getAccountResponseID();
            dbObj.Billings.Add(billing);
            try
            {
                await dbObj.SaveChangesAsync();
>>>>>>> Stashed changes
            }
            catch (DbUpdateException)
            {
                if (BillingExists(billing.BillId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBilling", new { id = billing.BillId }, billing);
        }

        private bool BillingExists(int id)         //Getting forien key 
        {
<<<<<<< Updated upstream
            return testDBobj.Billings.Any(e => e.BillId == id);
=======
            return dbObj.Billings.Any(e => e.BillId == id);
>>>>>>> Stashed changes
        }
    }
}

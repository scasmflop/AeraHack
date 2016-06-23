using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AeraHack2.Models;
using HackApp.Contracts;

namespace AeraHack2.Controllers
{
    [Authorize]
    public class HackWellsController : ApiController
    {
        private AeraLegoEntities1 db = new AeraLegoEntities1();

        // GET: api/HackWells
        public IQueryable<Completion> GetHackWells()
        {
            return db.HackWells.Select(hackWell => new Completion
            {
                CompletionId = hackWell.cmpl_fac_id,
                CompletionName = hackWell.cmpl_fac_nme,
                APINumber = hackWell.well_api_nbr,
                State = hackWell.fac_state_type_desc,
                Status = hackWell.svc_stat_indc,
                Material = hackWell.prim_prdt_matl_type_desc,
                PrimaryPurpose = hackWell.prim_purp_type_desc,
                Manifold = hackWell.PROD_MFLD_FAC_NME
            }).Take(50);
        }

        // GET: api/HackWells/3
        //public IQueryable<Completion> GetHackWells(int id)
        //{
        //    return db.HackWells.Select(hw => new Completion { CompletionId = hw.cmpl_fac_id, CompletionName = hw.cmpl_fac_nme }).Where(c => c.CompletionId == id);
        //}

        // GET: api/HackWells/5
        [ResponseType(typeof(Completion))]
        public async Task<IHttpActionResult> GetHackWells(decimal id)
        {
            var hackWell = await db.HackWells.FindAsync(id);

            if (hackWell == null)
            {
                return NotFound();
            }

            return Ok(new Completion
            {
                CompletionId = hackWell.cmpl_fac_id,
                CompletionName = hackWell.cmpl_fac_nme,
                APINumber = hackWell.well_api_nbr,
                State = hackWell.fac_state_type_desc,
                Status = hackWell.svc_stat_indc,
                Material = hackWell.prim_prdt_matl_type_desc,
                PrimaryPurpose = hackWell.prim_purp_type_desc,
                Manifold = hackWell.PROD_MFLD_FAC_NME
            });
        }

        // PUT: api/HackWells/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHackWell(decimal id, HackWell hackWell)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hackWell.cmpl_fac_id)
            {
                return BadRequest();
            }

            db.Entry(hackWell).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HackWellExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HackWells
        [ResponseType(typeof(HackWell))]
        public async Task<IHttpActionResult> PostHackWell(HackWell hackWell)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HackWells.Add(hackWell);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HackWellExists(hackWell.cmpl_fac_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hackWell.cmpl_fac_id }, hackWell);
        }

        // DELETE: api/HackWells/5
        [ResponseType(typeof(HackWell))]
        public async Task<IHttpActionResult> DeleteHackWell(decimal id)
        {
            HackWell hackWell = await db.HackWells.FindAsync(id);
            if (hackWell == null)
            {
                return NotFound();
            }

            db.HackWells.Remove(hackWell);
            await db.SaveChangesAsync();

            return Ok(hackWell);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HackWellExists(decimal id)
        {
            return db.HackWells.Count(e => e.cmpl_fac_id == id) > 0;
        }
    }
}
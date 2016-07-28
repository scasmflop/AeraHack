using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AeraHack2.Models;

namespace AeraHack2.Controllers
{
    public class PumpingUnitInspectionsController : ApiController
    {
        private AeraLegoEntities1 db = new AeraLegoEntities1();
        //private PumpingUnitInspectionsModel punitDb = new PumpingUnitInspectionsModel();

        // GET: api/PumpingUnitInspections
        //public IQueryable<v_PumpingUnitInspections> GetPumpingUnitInspections()
        //{
        //    return db.v_PumpingUnitInspections;
        //}

        // GET: api/PumpingUnitInspections/5
        [ResponseType(typeof(v_PumpingUnitInspections))]
        public IHttpActionResult GetPumpingUnitInspections(int id)
        {
            //v_PumpingUnitInspections pumpingUnitInspections = db.v_PumpingUnitInspections.Find(id);
            var pumpingUnitInspections = db.v_PumpingUnitInspections.Where(p => p.WellFacID == id);
            if (pumpingUnitInspections == null)
            {
                return NotFound();
            }

            return Ok(pumpingUnitInspections);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PumpingUnitInspectionsExists(int id)
        {
            return db.v_PumpingUnitInspections.Count(e => e.WellFacID == id) > 0;
        }
    }
}
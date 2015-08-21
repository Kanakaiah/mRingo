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
using mRingo.Data.Services.Models;
using mRingo.Data.Repositories.Models;
using mRingo.Data.Repositories.Disconnected;
using mRingo.Data.Models;

namespace mRingo.Data.Services.Controllers
{
    public class InstrumentMastersController : ApiController
    {
        private InstrumentMasterRepository db = new InstrumentMasterRepository(new UnitOfWork());


        // GET: api/InstrumentMasters
        public IQueryable<InstrumentMaster> GetInstrumentMasters()
        {
            return db.All;
        }

        // GET: api/InstrumentMasters/5
        [ResponseType(typeof(InstrumentMaster))]
        public IHttpActionResult GetInstrumentMaster(long id)
        {
            InstrumentMaster instrumentMaster = db.Find(id);
            if (instrumentMaster == null)
            {
                return NotFound();
            }

            return Ok(instrumentMaster);
        }

        // PUT: api/InstrumentMasters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInstrumentMaster(long id, InstrumentMaster instrumentMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != instrumentMaster.instrument_id)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(instrumentMaster);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrumentMasterExists(id))
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

        // POST: api/InstrumentMasters
        [ResponseType(typeof(InstrumentMaster))]
        public IHttpActionResult PostInstrumentMaster(InstrumentMaster instrumentMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(instrumentMaster);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = instrumentMaster.instrument_id }, instrumentMaster);
        }

        // DELETE: api/InstrumentMasters/5
        [ResponseType(typeof(InstrumentMaster))]
        public IHttpActionResult DeleteInstrumentMaster(long id)
        {
            InstrumentMaster instrumentMaster = db.Find(id);
            if (instrumentMaster == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(instrumentMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InstrumentMasterExists(long id)
        {
            return db.All.Count(e => e.instrument_id == id) > 0;
        }
    }
}
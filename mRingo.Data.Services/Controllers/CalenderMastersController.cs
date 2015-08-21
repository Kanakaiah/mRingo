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
    public class CalenderMastersController : ApiController
    {
        private CalenderMasterRepository db = new CalenderMasterRepository(new UnitOfWork());


        // GET: api/CalenderMasters
        public IQueryable<CalenderMaster> GetCalenderMasters()
        {
            return db.All;
        }

        // GET: api/CalenderMasters/5
        [ResponseType(typeof(CalenderMaster))]
        public IHttpActionResult GetCalenderMaster(long id)
        {
            CalenderMaster calenderMaster = db.Find(id);
            if (calenderMaster == null)
            {
                return NotFound();
            }

            return Ok(calenderMaster);
        }

        // PUT: api/CalenderMasters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCalenderMaster(long id, CalenderMaster calenderMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != calenderMaster.datekey)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(calenderMaster);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalenderMasterExists(id))
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

        // POST: api/CalenderMasters
        [ResponseType(typeof(CalenderMaster))]
        public IHttpActionResult PostCalenderMaster(CalenderMaster calenderMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(calenderMaster);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = calenderMaster.datekey }, calenderMaster);
        }

        // DELETE: api/CalenderMasters/5
        [ResponseType(typeof(CalenderMaster))]
        public IHttpActionResult DeleteCalenderMaster(long id)
        {
            CalenderMaster calenderMaster = db.Find(id);
            if (calenderMaster == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(calenderMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CalenderMasterExists(long id)
        {
            return db.All.Count(e => e.datekey == id) > 0;
        }
    }
}
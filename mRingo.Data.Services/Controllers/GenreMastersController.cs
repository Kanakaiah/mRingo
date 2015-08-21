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
    public class GenreMastersController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private GenreMasterRepository db = new GenreMasterRepository(new UnitOfWork());


        // GET: api/GenreMasters
        public IQueryable<GenreMaster> GetGenreMasters()
        {
            return db.All;
        }

        // GET: api/GenreMasters/5
        [ResponseType(typeof(GenreMaster))]
        public IHttpActionResult GetGenreMaster(long id)
        {
            GenreMaster genreMaster = db.Find(id);
            if (genreMaster == null)
            {
                return NotFound();
            }

            return Ok(genreMaster);
        }

        // PUT: api/GenreMasters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGenreMaster(long id, GenreMaster genreMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != genreMaster.genre_id)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(genreMaster);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenreMasterExists(id))
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

        // POST: api/GenreMasters
        [ResponseType(typeof(GenreMaster))]
        public IHttpActionResult PostGenreMaster(GenreMaster genreMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(genreMaster);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = genreMaster.genre_id }, genreMaster);
        }

        // DELETE: api/GenreMasters/5
        [ResponseType(typeof(GenreMaster))]
        public IHttpActionResult DeleteGenreMaster(long id)
        {
            GenreMaster genreMaster = db.Find(id);
            if (genreMaster == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(genreMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GenreMasterExists(long id)
        {
            return db.All.Count(e => e.genre_id == id) > 0;
        }
    }
}
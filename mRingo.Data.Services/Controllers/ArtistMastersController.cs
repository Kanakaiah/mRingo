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
    public class ArtistMastersController : ApiController
    {
        private ArtistMasterRepository db = new ArtistMasterRepository(new UnitOfWork());

        // GET: api/ArtistMasters
        public IQueryable<ArtistMaster> GetArtistMasters()
        {
            return db.All;
        }

        // GET: api/ArtistMasters/5
        [ResponseType(typeof(ArtistMaster))]
        public IHttpActionResult GetArtistMaster(long id)
        {
            ArtistMaster artistMaster = db.Find(id);
            if (artistMaster == null)
            {
                return NotFound();
            }

            return Ok(artistMaster);
        }

        // PUT: api/ArtistMasters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArtistMaster(long id, ArtistMaster artistMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != artistMaster.artist_info_id)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(artistMaster);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistMasterExists(id))
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

        // POST: api/ArtistMasters
        [ResponseType(typeof(ArtistMaster))]
        public IHttpActionResult PostArtistMaster(ArtistMaster artistMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(artistMaster);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = artistMaster.artist_info_id }, artistMaster);
        }

        // DELETE: api/ArtistMasters/5
        [ResponseType(typeof(ArtistMaster))]
        public IHttpActionResult DeleteArtistMaster(long id)
        {
            ArtistMaster artistMaster = db.Find(id);
            if (artistMaster == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(artistMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArtistMasterExists(long id)
        {
            return db.All.Count(e => e.artist_info_id == id) > 0;
        }
    }
}
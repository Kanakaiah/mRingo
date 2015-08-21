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
using mRingo.Data.Repositories.Disconnected;
using mRingo.Data.Repositories.Models;
using mRingo.Data.Models;

namespace mRingo.Data.Services.Controllers
{
    public class ArtistInstrumentsController : ApiController
    {
        private ArtistInstrumentRepository db = new ArtistInstrumentRepository(new UnitOfWork());

        // GET: api/ArtistInstruments
        public IQueryable<ArtistInstrument> GetArtistInstruments()
        {
            return db.All;
        }

        // GET: api/ArtistInstruments/5
        [ResponseType(typeof(ArtistInstrument))]
        public IHttpActionResult GetArtistInstrument(long id)
        {
            ArtistInstrument artistInstrument = db.Find(id);
            if (artistInstrument == null)
            {
                return NotFound();
            }

            return Ok(artistInstrument);
        }

        // PUT: api/ArtistInstruments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArtistInstrument(long id, ArtistInstrument artistInstrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != artistInstrument.artist_instrument_id)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(artistInstrument);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistInstrumentExists(id))
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

        // POST: api/ArtistInstruments
        [ResponseType(typeof(ArtistInstrument))]
        public IHttpActionResult PostArtistInstrument(ArtistInstrument artistInstrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(artistInstrument);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = artistInstrument.artist_instrument_id }, artistInstrument);
        }

        // DELETE: api/ArtistInstruments/5
        [ResponseType(typeof(ArtistInstrument))]
        public IHttpActionResult DeleteArtistInstrument(long id)
        {
            ArtistInstrument artistInstrument = db.Find(id);
            if (artistInstrument == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(artistInstrument);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArtistInstrumentExists(long id)
        {
            return db.All.Count(e => e.artist_instrument_id == id) > 0;
        }
    }
}
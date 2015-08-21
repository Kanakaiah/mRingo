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
    public class ArtistGenresController : ApiController
    {
        private ArtistGenreRepository db = new ArtistGenreRepository(new UnitOfWork());

        // GET: api/ArtistGenres
        public IQueryable<ArtistGenre> GetArtistGenres()
        {
            return db.All;
        }

        // GET: api/ArtistGenres/5
        [ResponseType(typeof(ArtistGenre))]
        public IHttpActionResult GetArtistGenre(long id)
        {
            ArtistGenre artistGenre = db.Find(id);
            if (artistGenre == null)
            {
                return NotFound();
            }

            return Ok(artistGenre);
        }

        // PUT: api/ArtistGenres/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArtistGenre(long id, ArtistGenre artistGenre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != artistGenre.artist_genre_id)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(artistGenre);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistGenreExists(id))
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

        // POST: api/ArtistGenres
        [ResponseType(typeof(ArtistGenre))]
        public IHttpActionResult PostArtistGenre(ArtistGenre artistGenre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(artistGenre);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = artistGenre.artist_genre_id }, artistGenre);
        }

        // DELETE: api/ArtistGenres/5
        [ResponseType(typeof(ArtistGenre))]
        public IHttpActionResult DeleteArtistGenre(long id)
        {
            ArtistGenre artistGenre = db.Find(id);
            if (artistGenre == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(artistGenre);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArtistGenreExists(long id)
        {
            return db.All.Count(e => e.artist_genre_id == id) > 0;
        }
    }
}
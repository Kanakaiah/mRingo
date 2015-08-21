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
    public class CustomerArtistInfoesController : ApiController
    {
        private CustomerArtistInfoRepository db = new CustomerArtistInfoRepository(new UnitOfWork());

        // GET: api/CustomerArtistInfoes
        public IQueryable<CustomerArtistInfo> GetCustomerArtistInfoes()
        {
            return db.All;
        }

        // GET: api/CustomerArtistInfoes/5
        [ResponseType(typeof(CustomerArtistInfo))]
        public IHttpActionResult GetCustomerArtistInfo(long id)
        {
            CustomerArtistInfo customerArtistInfo = db.Find(id);
            if (customerArtistInfo == null)
            {
                return NotFound();
            }

            return Ok(customerArtistInfo);
        }

        // PUT: api/CustomerArtistInfoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomerArtistInfo(long id, CustomerArtistInfo customerArtistInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customerArtistInfo.cust_artist_id)
            {
                return BadRequest();
            }

            db.InsertOrUpdate(customerArtistInfo);

            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerArtistInfoExists(id))
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

        // POST: api/CustomerArtistInfoes
        [ResponseType(typeof(CustomerArtistInfo))]
        public IHttpActionResult PostCustomerArtistInfo(CustomerArtistInfo customerArtistInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(customerArtistInfo);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = customerArtistInfo.cust_artist_id }, customerArtistInfo);
        }

        // DELETE: api/CustomerArtistInfoes/5
        [ResponseType(typeof(CustomerArtistInfo))]
        public IHttpActionResult DeleteCustomerArtistInfo(long id)
        {
            CustomerArtistInfo customerArtistInfo = db.Find(id);
            if (customerArtistInfo == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(customerArtistInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerArtistInfoExists(long id)
        {
            return db.All.Count(e => e.cust_artist_id == id) > 0;
        }
    }
}
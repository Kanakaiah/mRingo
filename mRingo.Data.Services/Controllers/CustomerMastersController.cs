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
using mRingo.Data.Repositories;
using mRingo.Data.Repositories.Disconnected;
using mRingo.Data.Models;

namespace mRingo.Data.Services.Controllers
{
    public class CustomerMastersController : ApiController
    {

        CustomerMasterRepository db = new CustomerMasterRepository(new UnitOfWork());

        // GET: api/CustomerMasters
        public IQueryable<CustomerMaster> GetCustomerMasters()
        {
            return db.All ;
        }

        // GET: api/CustomerMasters/5
        [ResponseType(typeof(CustomerMaster))]
        public IHttpActionResult GetCustomerMaster(long id)
        {
            CustomerMaster customerMaster = db.Find(id);
            if (customerMaster == null)
            {
                return NotFound();
            }

            return Ok(customerMaster);
        }

        // PUT: api/CustomerMasters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomerMaster(long id, CustomerMaster customerMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customerMaster.cust_info_id)
            {
                return BadRequest();
            }

            //db.Entry(customerMaster).State = EntityState.Modified;
            db.InsertOrUpdate(customerMaster);
            try
            {
                db.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerMasterExists(id))
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

        // POST: api/CustomerMasters
        [ResponseType(typeof(CustomerMaster))]
        public IHttpActionResult PostCustomerMaster(CustomerMaster customerMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InsertOrUpdate(customerMaster);
            db.Save();

            return CreatedAtRoute("DefaultApi", new { id = customerMaster.cust_info_id }, customerMaster);
        }

        // DELETE: api/CustomerMasters/5
        [ResponseType(typeof(CustomerMaster))]
        public IHttpActionResult DeleteCustomerMaster(long id)
        {
            CustomerMaster customerMaster = db.Find(id);
            if (customerMaster == null)
            {
                return NotFound();
            }

            db.Delete(id);
            db.Save();

            return Ok(customerMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerMasterExists(long id)
        {
            return db.All.Count(e => e.cust_info_id == id) > 0;
        }
    }
}
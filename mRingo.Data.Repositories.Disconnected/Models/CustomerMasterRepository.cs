using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using mRingo.Data;
using mRingo.Data.Interfaces;
using mRingo.Data.Repositories.Disconnected;
using mRingo.Data.Models;

namespace mRingo.Data.Repositories
{ 
    public class CustomerMasterRepository : ICustomerMasterRepository
    {
         private readonly mRingoContext context;
         public CustomerMasterRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        public IQueryable<CustomerMaster> All
        {
            get { return context.CustomerMasters; }
        }

        public IQueryable<CustomerMaster> AllIncluding(params Expression<Func<CustomerMaster, object>>[] includeProperties)
        {
            IQueryable<CustomerMaster> query = context.CustomerMasters;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CustomerMaster Find(long id)
        {
            return context.CustomerMasters.Find(id);
        }

        public void InsertOrUpdate(CustomerMaster customermaster)
        {
            if (customermaster.cust_info_id == default(long)) {
                // New entity
                //context.CustomerMasters.Add(customermaster);
                context.Entry(customermaster).State=System.Data.Entity.EntityState.Added;
            }
            else {
                // Existing entity
                context.Entry(customermaster).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var customermaster = context.CustomerMasters.Find(id);
            context.CustomerMasters.Remove(customermaster);
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface ICustomerMasterRepository : IEntityRepository<CustomerMaster>
    {
        
    }
}
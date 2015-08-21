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
using System.Data.Entity.Infrastructure;

namespace mRingo.Data.Repositories.Models
{
    public class CustomerInquiryRepository : ICustomerInquiryRepository
    {
        private readonly mRingoContext context;
        public CustomerInquiryRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        public IQueryable<CustomerInquiry> All
        {
            get { return context.CustomerInquiries; }
        }

        public IQueryable<CustomerInquiry> AllIncluding(params Expression<Func<CustomerInquiry, object>>[] includeProperties)
        {
            IQueryable<CustomerInquiry> query = context.CustomerInquiries;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CustomerInquiry Find(long id)
        {
            return context.CustomerInquiries.Find(id);
        }

        public void InsertOrUpdate(CustomerInquiry customerinquiry)
        {
            if (customerinquiry.inquiry_id == default(long)) {
                // New entity
                context.CustomerInquiries.Add(customerinquiry);
            } else {
                // Existing entity
                context.Entry(customerinquiry).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var customerinquiry = context.CustomerInquiries.Find(id);
            context.CustomerInquiries.Remove(customerinquiry);
        }

        public int Save()
        {

            bool saveFailed;
            do
            {
                saveFailed = false;

                try
                {
                    return context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    // Update the values of the entity that failed to save from the store 
                    ex.Entries.Single().Reload();

                    var entry = ex.Entries.Single();
                    var databaseValues = entry.GetDatabaseValues();
                    var databaseValuesAsBlog = (CustomerInquiry)databaseValues.ToObject();

                    // Choose an initial set of resolved values. In this case we 
                    // make the default be the values currently in the database. 
                    var resolvedValuesAsBlog = (CustomerInquiry)databaseValues.ToObject();

                    // Have the user choose what the resolved values should be 
                    HaveUserResolveConcurrency((CustomerInquiry)entry.Entity,
                                               databaseValuesAsBlog,
                                               resolvedValuesAsBlog);

                    // Update the original values with the database values and 
                    // the current values with whatever the user choose. 
                    entry.OriginalValues.SetValues(databaseValues);
                    entry.CurrentValues.SetValues(resolvedValuesAsBlog); 


                }

            } while (saveFailed);
            return 0;

        }

        public void HaveUserResolveConcurrency(CustomerInquiry entity,
                                       CustomerInquiry databaseValues,
                                       CustomerInquiry resolvedValues)
        {
            // Show the current, database, and resolved values to the user and have 
            // them update the resolved values to get the correct resolution. 
        }


        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface ICustomerInquiryRepository : IEntityRepository<CustomerInquiry>
    {

    }
}
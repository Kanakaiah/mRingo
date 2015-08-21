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

namespace mRingo.Data.Repositories.Models
{ 
    public class CustomerArtistInfoRepository : ICustomerArtistInfoRepository
    {
        private readonly mRingoContext context;
        public CustomerArtistInfoRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        public IQueryable<CustomerArtistInfo> All
        {
            get { return context.CustomerArtistInfoes; }
        }

        public IQueryable<CustomerArtistInfo> AllIncluding(params Expression<Func<CustomerArtistInfo, object>>[] includeProperties)
        {
            IQueryable<CustomerArtistInfo> query = context.CustomerArtistInfoes;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CustomerArtistInfo Find(long id)
        {
            return context.CustomerArtistInfoes.Find(id);
        }

        public void InsertOrUpdate(CustomerArtistInfo customerartistinfo)
        {
            if (customerartistinfo.cust_artist_id == default(long)) {
                // New entity
                context.CustomerArtistInfoes.Add(customerartistinfo);
            } else {
                // Existing entity
                context.Entry(customerartistinfo).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var customerartistinfo = context.CustomerArtistInfoes.Find(id);
            context.CustomerArtistInfoes.Remove(customerartistinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface ICustomerArtistInfoRepository : IEntityRepository<CustomerArtistInfo>
    {
    }
}
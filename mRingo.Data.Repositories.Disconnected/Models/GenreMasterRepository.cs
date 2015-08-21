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
    public class GenreMasterRepository : IGenreMasterRepository
    {
        private readonly mRingoContext context;
        public GenreMasterRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        public IQueryable<GenreMaster> All
        {
            get { return context.GenreMasters; }
        }

        public IQueryable<GenreMaster> AllIncluding(params Expression<Func<GenreMaster, object>>[] includeProperties)
        {
            IQueryable<GenreMaster> query = context.GenreMasters;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public GenreMaster Find(long id)
        {
            return context.GenreMasters.Find(id);
        }

        public void InsertOrUpdate(GenreMaster genremaster)
        {
            if (genremaster.genre_id == default(long)) {
                // New entity
                context.GenreMasters.Add(genremaster);
            } else {
                // Existing entity
                context.Entry(genremaster).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var genremaster = context.GenreMasters.Find(id);
            context.GenreMasters.Remove(genremaster);
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

    public interface IGenreMasterRepository : IEntityRepository<GenreMaster>
    {
    }
}
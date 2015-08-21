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
    public class ArtistMasterRepository : IArtistMasterRepository
    {
         private readonly mRingoContext context;
         public ArtistMasterRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }


        public IQueryable<ArtistMaster> All
        {
            get { return context.ArtistMasters; }
        }

        public IQueryable<ArtistMaster> AllIncluding(params Expression<Func<ArtistMaster, object>>[] includeProperties)
        {
            IQueryable<ArtistMaster> query = context.ArtistMasters;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ArtistMaster Find(long id)
        {
            return context.ArtistMasters.Find(id);
        }

        public void InsertOrUpdate(ArtistMaster artistmaster)
        {
            if (artistmaster.artist_info_id == default(long)) {
                // New entity
                context.ArtistMasters.Add(artistmaster);
            } else {
                // Existing entity
                context.Entry(artistmaster).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var artistmaster = context.ArtistMasters.Find(id);
            context.ArtistMasters.Remove(artistmaster);
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

    public interface IArtistMasterRepository : IEntityRepository<ArtistMaster>
    {
    }
}
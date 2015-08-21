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
    public class ArtistInstrumentRepository : IArtistInstrumentRepository
    {
        private readonly mRingoContext context;

        public ArtistInstrumentRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        
        public IQueryable<ArtistInstrument> All
        {
            get { return context.ArtistInstruments; }
        }

        public IQueryable<ArtistInstrument> AllIncluding(params Expression<Func<ArtistInstrument, object>>[] includeProperties)
        {
            IQueryable<ArtistInstrument> query = context.ArtistInstruments;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ArtistInstrument Find(long id)
        {
            return context.ArtistInstruments.Find(id);
        }

        public void InsertOrUpdate(ArtistInstrument artistinstrument)
        {
            if (artistinstrument.artist_instrument_id == default(long)) {
                // New entity
                context.ArtistInstruments.Add(artistinstrument);
            } else {
                // Existing entity
                context.Entry(artistinstrument).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var artistinstrument = context.ArtistInstruments.Find(id);
            context.ArtistInstruments.Remove(artistinstrument);
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

    public interface IArtistInstrumentRepository : IEntityRepository<ArtistInstrument> 
    {
    }
}
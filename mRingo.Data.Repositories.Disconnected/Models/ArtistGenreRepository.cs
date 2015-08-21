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
    public class ArtistGenreRepository : IArtistGenreRepository
    {

        private readonly mRingoContext context;
        public ArtistGenreRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        public IQueryable<ArtistGenre> All
        {
            get { return context.ArtistGenres; }
        }

        public IQueryable<ArtistGenre> AllIncluding(params Expression<Func<ArtistGenre, object>>[] includeProperties)
        {
            IQueryable<ArtistGenre> query = context.ArtistGenres;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ArtistGenre Find(long id)
        {
            return context.ArtistGenres.Find(id);
        }

        public void InsertOrUpdate(ArtistGenre artistgenre)
        {
            if (artistgenre.artist_genre_id == default(long)) {
                // New entity
                context.ArtistGenres.Add(artistgenre);
            } else {
                // Existing entity
                context.Entry(artistgenre).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var artistgenre = context.ArtistGenres.Find(id);
            context.ArtistGenres.Remove(artistgenre);
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

    public interface IArtistGenreRepository : IEntityRepository<ArtistGenre>
    {
    }
}
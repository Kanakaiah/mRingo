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
    public class InstrumentMasterRepository : IInstrumentMasterRepository
    {
         private readonly mRingoContext context;
         public InstrumentMasterRepository(UnitOfWork uow)
        {
            context = uow.Context;
        }

        public IQueryable<InstrumentMaster> All
        {
            get { return context.InstrumentMasters; }
        }

        public IQueryable<InstrumentMaster> AllIncluding(params Expression<Func<InstrumentMaster, object>>[] includeProperties)
        {
            IQueryable<InstrumentMaster> query = context.InstrumentMasters;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public InstrumentMaster Find(long id)
        {
            return context.InstrumentMasters.Find(id);
        }

        public void InsertOrUpdate(InstrumentMaster instrumentmaster)
        {
            if (instrumentmaster.instrument_id == default(long)) {
                // New entity
                context.InstrumentMasters.Add(instrumentmaster);
            } else {
                // Existing entity
                context.Entry(instrumentmaster).State = System.Data.Entity.EntityState.Modified; 
            }
        }

        public void Delete(long id)
        {
            var instrumentmaster = context.InstrumentMasters.Find(id);
            context.InstrumentMasters.Remove(instrumentmaster);
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

    public interface IInstrumentMasterRepository : IEntityRepository<InstrumentMaster>
    {
    }
}
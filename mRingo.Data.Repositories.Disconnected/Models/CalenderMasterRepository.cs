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
    public class CalenderMasterRepository : ICalenderMasterRepository
    {
         private readonly mRingoContext context;
         public CalenderMasterRepository(UnitOfWork uow)
         {
             context = uow.Context;
         }

        public IQueryable<CalenderMaster> All
        {
            get { return context.CalenderMasters; }
        }

        public IQueryable<CalenderMaster> AllIncluding(params Expression<Func<CalenderMaster, object>>[] includeProperties)
        {
            IQueryable<CalenderMaster> query = context.CalenderMasters;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CalenderMaster Find(long id)
        {
            return context.CalenderMasters.Find(id);
        }

        public void InsertOrUpdate(CalenderMaster calendermaster)
        {
            if (calendermaster.datekey == default(long)) {
                // New entity
                context.CalenderMasters.Add(calendermaster);
            } else {
                // Existing entity
                context.Entry(calendermaster).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var calendermaster = context.CalenderMasters.Find(id);
            context.CalenderMasters.Remove(calendermaster);
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

    public interface ICalenderMasterRepository : IEntityRepository<CalenderMaster>
    {
    }
}
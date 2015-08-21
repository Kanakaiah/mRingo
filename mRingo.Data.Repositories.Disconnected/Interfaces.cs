using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mRingo.Data.Interfaces
{

    //public interface IAccountRepository : IEntityRepository<CustomerMaster>
    //{

    //}


    public interface IEntityRepository<T> : IDisposable
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(long id);
        void InsertOrUpdate(T entity);
        void Delete(long id);
        //void Save();
    }

    

}


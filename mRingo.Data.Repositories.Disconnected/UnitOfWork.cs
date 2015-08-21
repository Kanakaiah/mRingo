using mRingo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mRingo.Data.Repositories.Disconnected
{
    public class UnitOfWork : IUnitOfWork<mRingoContext>
    {
        private readonly mRingoContext _context;


        public UnitOfWork()
        {
            _context = new mRingoContext();
        }

        public UnitOfWork(mRingoContext context)
        {
            _context = context;
        }
        public int Save()
        {
            return _context.SaveChanges();
        }

        public mRingoContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
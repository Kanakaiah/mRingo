using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mRingo.Data
{
    public partial class BaseContext<TContext>
    : DbContext where TContext : DbContext
    {
        static BaseContext() //no public class
        {
            Database.SetInitializer<TContext>(null);
        }
        protected BaseContext() // no public class
            : base("Name=mRingoContext")
        { }
    }

}


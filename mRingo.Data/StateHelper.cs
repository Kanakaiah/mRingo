using mRingo.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mRingo.Data
{
    public class StateHelper
    {
        public static EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Modified:
                    return EntityState.Modified;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }

        }
    }

    //State of the graph in disconnected 
    public static class ContextHelpers
    {
        //Only use with short lived contexts
        public static void ApplyStateChanges(this DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
            {
                IObjectWithState stateInfo = entry.Entity;
                entry.State = StateHelper.ConvertState(stateInfo.State);
            }
        }
    }
}

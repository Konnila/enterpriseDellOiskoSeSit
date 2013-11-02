using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace Duudelides.Repositories
{
    public class BaseRepository
    {
        public static readonly string DbContext = "DBCONTEXT";

        protected virtual DoodelDBEntities GetDbContext()
        {
            var context = HttpContext.Current.Items[DbContext] as DoodelDBEntities;

            if (context != null)
            {
                return context;
            }

            throw new InstanceNotFoundException("DBContext was null. Does requesting method invoke the TransactionAttribute?");
        }
    }
}
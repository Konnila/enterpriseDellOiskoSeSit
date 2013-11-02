using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duudelides.Repositories
{
    public class DoodelRepository : BaseRepository
    {
        public DoodelRepository()
        {
            
        }
        public void CreateDoodel(Doodel doodel)
        {
            var db = GetDbContext();

            db.Doodel.Add(doodel);
            db.SaveChanges();
        }
    }
}
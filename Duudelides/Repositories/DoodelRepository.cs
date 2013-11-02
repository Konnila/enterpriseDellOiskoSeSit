using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Duudelides.Repositories
{
    public class DoodelRepository : BaseRepository
    {
        public DoodelRepository()
        {
            
        }
        public void CreateDoodel(Doodel doodel, int userId)
        {
            var db = GetDbContext();

            Doodel ddl = db.Doodel.Add(doodel);

            var userDoodel = new UsersDoodle
            {
                UserId = userId,
                DoodelId = ddl.Id
            };

            db.UsersDoodle.Add(userDoodel);

            db.SaveChanges();
        }

        public IEnumerable<Doodel> Get(Expression<Func<Doodel, bool>> where)
        {
            var db = GetDbContext();

            return db.Doodel.Where(where);
        }

        internal IEnumerable<Doodel> GetAllDoodels()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersDoodle> GetUserDoodels()
        {
            var db = GetDbContext();

            return db.UsersDoodle;
        }

        public IEnumerable<UserDoodelChoices> GetAllUserDoodleChoices()
        {
            var db = GetDbContext();

            return db.UserDoodelChoices;
        }
    }
}
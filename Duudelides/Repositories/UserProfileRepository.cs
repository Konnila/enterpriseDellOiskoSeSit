using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duudelides.Repositories
{
    public class UserProfileRepository : BaseRepository
    {
        public UserProfileRepository()
        {
            
        }

        public UserProfile GetUser(int id)
        {
            var db = GetDbContext();

            return db.UserProfile.SingleOrDefault(x => x.UserId == id);
        }
    }
}
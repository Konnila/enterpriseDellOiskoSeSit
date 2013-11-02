using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Duudelides.Repositories;

namespace Duudelides.Services
{
    public class UserProfileService
    {
        private UserProfileRepository userRepository;
        public UserProfileService()
        {
            userRepository = new UserProfileRepository();
        }

        public UserProfile GetUser(int id)
        {
            return userRepository.GetUser(id);
        }
    }
}
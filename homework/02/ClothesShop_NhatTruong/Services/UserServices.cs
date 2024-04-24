using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices
    {
        private UserPepositories _userPepositories = new();
        public User? GetUser(string email, string password, out int role)
        {
            User? user = _userPepositories.GetUser(email, password);
            if (user != null)
                role = user.Roleid;
            else
                role = 0;
            return user;
        }
            
    }
}

using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        private UserRepositori _userrepositori = new();
        public Member? CheckLogin(string email, string password) =>
            _userrepositori.GetMember(email, password);
    }
}

using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepositori
    {
        public Member? GetMember(string email,string password)
        => new WatchDb2024Context().Members.ToList().FirstOrDefault(x => x.Email == email && x.Password == password);
    }
}

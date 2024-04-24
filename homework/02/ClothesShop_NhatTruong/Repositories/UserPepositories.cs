using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserPepositories
    {
        public User? GetUser(string email, string password)
            => new ClothesShopContext().Users.FirstOrDefault(
                x => x.Email.Equals(email) && x.Password.Equals(password));
    }
}

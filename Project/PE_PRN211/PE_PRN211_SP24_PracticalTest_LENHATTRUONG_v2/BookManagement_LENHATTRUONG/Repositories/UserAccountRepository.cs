using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        public bool Checklogin(string gmail, string password)
             => new BookManagementDbContext().UserAccounts.ToList()
            .Any(x => x.Email.Equals(gmail) && x.Password.Equals(password));

        //{
        //    //List<UserAccount> list = new BookManagementDbContext().UserAccounts.ToList();          
        //    //return list.Any(x => x.Email.Equals(gmail)&&x.Password.Equals(password));


        //}

    }
}

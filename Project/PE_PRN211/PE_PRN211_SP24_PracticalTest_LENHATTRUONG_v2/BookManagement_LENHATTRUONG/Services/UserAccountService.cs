using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repository = new();
        public bool IsLoggedIn(string gmail,string password)
            => _repository.Checklogin(gmail, password);
        
    }
}

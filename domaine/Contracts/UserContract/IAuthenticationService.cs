using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Contracts.UserContract
{
    public interface IAuthenticationService
    {
        public bool IsUsed(string username);
        public bool Register(string username, string password);
        public bool Login(string username, string password);
    }
}

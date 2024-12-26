using cw__17.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Contracts.UserContract
{
    public interface IUserRepository
    {
        public List<User> GetAll();
        public User GetByUserName(string UserName);
        public bool Creat(User user);
        
    }
}

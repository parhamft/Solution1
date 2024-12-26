using cw__17.AppDataBase.Repository;
using cw__17.Models.Contract.CategoryContract;
using cw__17.Models.Entities;
using domain.Contracts.UserContract;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _UserRepository;
        public AuthenticationService()
        {
            _UserRepository =new UserRepository();
        }

        public bool IsUsed(string username)
        {
            User user= _UserRepository.GetByUserName(username);
            if (user == null) { return false; }
            return true;
        }

        public bool Login(string username, string password)
        {
            User user = _UserRepository.GetByUserName(username);
            if (user==null) { return false; }
            if (user.Password != password) { return false; }
            Auth.CurrentUser = user;
            return true;
        }

        public bool Register(string username, string password)
        {
            User user = new User() { UserName = username, Password=password };
            _UserRepository.Creat(user);
            return true;
        }
    }
}

using cw__17.Models.Entities;
using domain.Contracts.UserContract;
using System.Linq.Expressions;

namespace cw__17.AppDataBase.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public bool Creat(User user)
        {
            
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
            
        }

        public List<User> GetAll()
        => _context.Users.ToList();

        public User GetByUserName(string UserName)
        
             => _context.Users.FirstOrDefault(x=>x.UserName==UserName);
        
    }
}

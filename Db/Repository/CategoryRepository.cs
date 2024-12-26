using cw__17.Models.Contract.CategoryContract;
using cw__17.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace cw__17.AppDataBase.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository()
        {
            _context = new AppDbContext();
        }
        public void Creat(Category category)
        {
            var cat = _context.Categories.Add(category);
            _context.SaveChanges();
            
        }

        public List<Category> GetAll()
            => _context.Categories.ToList();
        public Category GetById(int id)
            => _context.Categories.Include(x => x.Products).FirstOrDefault(x => x.Id == id);
        

    }
}

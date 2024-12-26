using cw__17.Models.Contract.ProductContract;
using cw__17.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace cw__17.AppDataBase.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository()
        {
            _context = new AppDbContext();
        }
        public List<Product> GetAll()

       => _context.Products.Include(p => p.Category).ToList();
    }
}

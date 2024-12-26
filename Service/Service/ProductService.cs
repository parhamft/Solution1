using cw__17.AppDataBase.Repository;
using cw__17.Models.Contract.ProductContract;
using cw__17.Models.Entities;

namespace cw__17.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService()
        {
            _repository = new ProductRepository();
        }
        public List<Product> GetAll()

            => _repository.GetAll();
    }
}
